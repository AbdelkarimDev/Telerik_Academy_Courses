String.prototype.htmlEscape = function() {
    let escapedStr = String(this)
        .replace(/&/g, '&amp;');
    .replace(/</g, '&lt;');
    .replace(/>/g, '&gt;');
    .replace(/"/g, '&quot;');
    .replace(/'/g, '&#39');
    return escapedStr;
}

Array.prototype.removeElement = function(element) {
    var index = this.indexOf(element);
    while (index > -1) {
        this.splice(index, 1);
        index = this.indexOf(element);
    }

    return this;
};

Array.prototype.scanLeft = function(aggregate, initial) {
        const len = this.length;
        let array = [];
        let startIndex = 0;
        if (typeof initial === 'undefined') {
            initial = this[0];
            startIndex = 1;
        }

        Array.prototype.forEach = function(func) {
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                func(this[i], i, this);
            }
        };


        Array.prototype.every = function(isOk) {
            // console.log('Our function is called');
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                console.log(isOk(this[i], i, this));
                if (!isOk(this[i], i, this)) {
                    return false;
                }
            }
            return true;
        };

        Array.prototype.some = function(isOk) {
            //console.log('Our function is called');
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                if (isOk(this[i], i, this)) {
                    return true;
                }
            }
            return false;
        };

        Array.prototype.find = function(isOk) {
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                if (isOk(this[i], i, this)) {
                    return this[i];
                }
            }
        }

        Array.prototype.findIndex = function(isOk) {
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                if (isOk(this[i], i, this)) {
                    return i;
                }
            }
            return -1;
        }


        Array.prototype.filter = function(isOk) {
            let filteredArray = [];
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                if (isOk(this[i], i, this)) {
                    filteredArray.push(this[i]);
                }
            }
            return filteredArray;
        };

        Array.prototype.map = function(transform) {
            let mappedArray = [];
            const len = this.length;
            for (let i = 0; i < len; i += 1) {
                mappedArray.push(transform(this[i], i, this));
            }
            return mappedArray;
        };

        Array.prototype.reduce = function(aggregate, initial) {
            const len = this.length;
            let startIndex = 0;
            if (typeof initial === 'undefined') {
                initial = this[0];
                startIndex = 1;
            }
            for (let i = startIndex; i < len; i += 1) {
                initial = aggregate(initial, this[i], i, this);
            }
            return initial;
        };

        Array.prototype.reduceRight = function(aggregate, initial) {
            const len = this.length;
            let startIndex = len - 1;
            if (typeof initial === 'undefined') {
                initial = this[0];
                startIndex = len - 2;
            }
            for (let i = startIndex; i >= 0; i -= 1) {
                initial = aggregate(initial, this[i], i, this);
            }
            return initial;
        };

        Array.prototype.scanLeft = function(aggregate, initial) {
            const len = this.length;
            let array = [];
            let startIndex = 0;
            if (typeof initial === 'undefined') {
                initial = this[0];
                startIndex = 1;
            }
            array.push(initial);
            for (let i = startIndex; i < len; i += 1) {
                initial = aggregate(initial, this[i], i, this);
                array.push(initial);
            }
            return array;
        };