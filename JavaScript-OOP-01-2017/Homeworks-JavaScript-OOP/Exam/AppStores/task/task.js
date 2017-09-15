function solve() {

    const counter = (function() {
        let counter = 0;
        return function() {
            counter += 1;
            return counter;
        };
    })();

    const Validator = {
        validateString(str) {
            if (typeof str !== 'string') {
                throw new Error('Invalid description');
            }
        },
        validateName(name) {
            if (typeof name !== 'string' || !name.match(/^([A-Za-z0-9 ]{1,24})$/)) {
                throw new Error('Invalid Name');
            }
        },
        validateVersion(version) {
            if (typeof version !== 'number' || isNaN(version) || version < 0) {
                throw new Error('Invalid version')
            }
        },
        validateRating(rating) {
            if (typeof rating !== 'number' || isNaN(rating) || rating < 1 || rating > 10) {
                throw new Error('Invalid rating')
            }
        },
        validateHostName(hostname) {
            if (typeof hostname !== 'string' || hostname.length < 1 || hostname.length > 32) {
                throw new Error('Invalid Hostname')
            }
        },
        validateApp(app) {
            try {
                new App(app.name, app.description, app.version, app.rating);

            } catch (e) {
                throw Error('Invalid App');
            }

        }
    }


    class App {
        constructor(name, description, version, rating) {
            this.name = name;
            this.description = description;
            this.version = version;
            this.rating = rating;

        }

        get name() {
            return this._name;
        }
        set name(name) {
            Validator.validateName(name);

            this._name = name;
        }
        get description() {

            return this._description;
        }
        set description(description) {
            Validator.validateString(description);
            this._description = description;
        }
        get version() {
            return this._version;
        }
        set version(version) {
            Validator.validateVersion(version);
            this._version = version;
        }
        get rating() {
            return this._rating;
        }
        set rating(rating) {
            Validator.validateRating(rating);
            this._rating = rating;
        }

        release(options) {
            if (typeof options === 'number') {
                if (options < this.version) {
                    throw new Error('Invalid Version')
                }
                return this.version = options;
            }
            if (typeof options === 'object') {

                Validator.validateVersion(options.version)

                if (options.version < this.version) {
                    throw new Error('new version is not above the old one')

                }
                if (typeof options.version === 'undefined') {
                    throw new Error('version is not specified')
                }
            }
            Validator.validateString(options.description);
            Validator.validateRating(options.rating);
            return this.version = options.version,
                this.description = options.description,
                this.rating = options.rating;


        }

    }
    class Store extends App {
        constructor(name, description, version, rating) {
            super(name, description, version, rating);
            this._apps = [];

        }
        get apps() {
            return this._apps;
        }
        set apps(apps) {
            this._apps = apps;
        }


        uploadApp(app) {
            Validator.validateApp(app);
            let appToUpload = this._apps.find(a => a.name === app.name &&
                a.description === app.description &&
                a.rating === app.rating);

            if (appToUpload === 'undefined') {
                // throw Error(`app doesn't exist`);
                this._apps.push(new App(app.name, app.description, app.version, app.rating));

            } else {
                appToUpload.description = app.description;
                appToUpload.rating = app.rating;

                if (appToUpload.version > app.version) {
                    throw new Error('the new version is not bigger than the old one')
                }
            }
            this._apps.push(app);

            return this;

        }
        takedownApp(name) {
            let index = this._apps.findIndex(a => a.name === name);
            if (index < 0) {
                throw new Error('There is no such app with that name!');
            }
            this._apps.splice(index, 1);
            return this;
        }
        search(pattern) {
            return this._apps
                .map(app => app.name.toLowerCase())
                .filter(app => {
                    return (
                        app.name.indexOf(pattern.toLowerCase()) >= 0)
                })
                .sort((x, y) => x.name.localeCompare(y.name));

        }

        listMostRecentApps(count) {
            if (typeof count === 'undefined') {
                count = 10;
            }

            this.apps
                .slice()
                .sort((x, y) => y.rating - x.rating)
                .slice(0, count);
        }
        listMostPopularApps(count) {
            if (typeof count === 'undefined') {
                count = 10;
            }

            this.apps
                .slice()
                .sort((x, y) => {
                    if (x.rating === y.rating) {
                        return y.version - x.version;
                    }
                    return y.rating - x.rating;
                })
                .slice(0, count);
        }



    }
    class Device {
        constructor(hostname, apps) {
            this.hostname = hostname;
            this.apps = apps;
            this._stores = [];
        }
        get stores() {
            return this._stores;
        }
        get hostname() {
            return this._hostname;
        }
        set hostname(hostname) {
            Validator.validateHostName(hostname);
            this._hostname = hostname;
        }

        get apps() {
            return this._apps;
        }
        set apps(apps) {
            apps.forEach(app => {
                if (typeof app !== 'object') {
                    throw 'Item not an object';
                }
                validateApp(app);

            });

            this._apps = apps;
        }

        search(pattern) {
            return this._stores
                .slice()
                .map(store => store.apps.name.toLowerCase())
                .filter(app => {
                    return (
                        app.name.indexOf(pattern.toLowerCase()) >= 0)
                })
                .sort((x, y) => {
                    if (x.name === y.name) { //number
                        return y.version - x.version;
                    }
                    return x.name.localeCompare(y.name);
                })
                .filter((v, i, vs) => v = vs[0]);

        }
        install(name) {

            let app = this.apps.find(a => a.name === name);
            if (app === 'undefined') {
                throw Error(`app doesn't exist`);
            }
            let appLastVersion = app.sort((x, y) => y.version - x.version)[0];
            this._apps.push(appLastVersion);

            return this;

        }
        uninstall(name) {
            let index = this.apps.findIndex(a => a.name === name);
            if (index < 0) {
                throw new Error('No such app with that name!');
            }
            this.apps.splice(index, 1);
            return this;
        }
        listInstalled() {
            return this.apps
                .sort((x, y) => x.name.localeCompare(y.name));

        }
        update() {

        }


    }


    return {
        createApp(name, description, version, rating) {
            // returns a new App object
            return new App(name, description, version, rating);
        },
        createStore(name, description, version, rating) {
            // returns a new Store object
            return new Store(name, description, version, rating);
        },
        createDevice(hostname, apps) {
            // returns a new Device object
            return new Device(hostname, apps);
        }
    };
}

// Submit the code above this line in bgcoder.com
module.exports = solve;