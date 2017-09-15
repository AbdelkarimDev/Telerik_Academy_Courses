/* Task Description */

/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {

    var Course = {
        init: function(title, presentations) {

            validateTitle(title);
            validatePresentations(presentations);

            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },

        addStudent: function(name) {
            let fullName = name.split(' ').filter(name => {
                return name;
            });

            validateName(fullName[0]);
            validateName(fullName[1]);

            if (fullName.length !== 2) {
                throw new Error('Parameter must consist of both first and last name!');
            }

            let id = this.students.length + 1;
            let student = {
                firstName: fullName[0],
                lastName: fullName[1],
                id: id,
                homeworks: [],
                examScore: 0,
                finalScore: 0
            };

            this.students.push(student);

            return id;
        },

        getAllStudents: function() {
            return this.students.map(st => {
                return {
                    firstname: st.firstName,
                    lastname: st.lastName,
                    id: st.id
                };
            });
        },

        submitHomework: function(studentID, homeworkID) {

            validateID(studentID);
            validateID(homeworkID);

            if (studentID > this.students.length) {
                throw new Error('Invalid student ID!');
            }

            if (homeworkID > this.presentations.length) {
                throw new Error('Invalid homework ID!');
            }

            studentID = +studentID;
            homeworkID = +homeworkID;

            let currStudent = this.students[studentID - 1];

            if (currStudent.homeworks.indexOf(homeworkID) === -1) {
                currStudent.homeworks.push(homeworkID);
            }

            return this;
        },



        pushExamResults: function(results) {

            validateExamResults(results);

            for (let i = 0, len = results.length; i < len; i += 1) {
                let currStudentID = results[i].StudentID,
                    currStudentScore = results[i].score;

                validateID(currStudentID);

                if (!isFinite(currStudentScore)) {
                    throw new Error('Student score must be a valid number!');
                }

                currStudentID = +currStudentID;
                currStudentScore = +currStudentScore;

                if (currStudentID > this.students.length) {
                    throw new Error('Invalid student ID!');
                }

                if (this.students[currStudentID - 1].examScore !== 0) {
                    throw new Error('This student already has a score!');
                }

                this.students[currStudentID - 1].examScore = currStudentScore;
            }

            return this;
        },


        getTopStudents: function() {

            this.students.forEach(student => {
                student.finalScore = (0.75 * student.examScore) + (0.25 * student.homeworks.length / this.presentations.length);
            });

            this.students.sort((st1, st2) => {
                return st2.finalScore - st1.finalScore;
            });

            let topStudentCount = 10;
            topTenStudents = [];

            if (this.students.length < 10) {
                topStudentCount = this.students.length;
            }

            for (let i = 0; i < topStudentCount; i += 1) {
                let topStudent = {
                    firstName: this.student[i].firstName,
                    lastName: this.student[i].lastName,
                    id: this.student[i].id
                }
            }

        }
    };

    function validateTitle(title) {
        if (!(/^\S+(?: \S+)*$/.test(title))) {
            throw new Error('Invalid Title');
        }
    }

    function validatePresentations(presentations) {

        if (!presentations || !Array.isArray(presentations) || presentations.length === 0) {
            throw new Error('Invalid presentations parameter!');
        }

        // for (let i = 0, len = presentations.length; i < len; i += 1) {
        //     validateTitle(presentations[i]);
        // }
        presentations.forEach(x => validateTitle(x));
    }

    function validateName(name) {
        if (!(/^[A-Z][a-z]*$/.test(name))) {
            throw new Error('Invalid Name')
        }
    }

    function validateID(id) {
        if (!(/^\d+$/.test(id))) {
            throw new Error('Invalid ID')
        }

        if (id < 1) {
            throw new Error('Id must be more then 0')
        }
        // if (!id) {
        //     throw new Error('Invalid input for id!');
        // }

        // if (id % 1 !== 0) {
        //     throw new Error('Id must be an integer number!');
        // }

        // if (!Number(id)) {
        //     throw new Error('Id must be a number!');
        // }
    }

    function validateExamResults(results) {

        if (!results || !Array.isArray(results)) {
            throw new Error('Exam results must be an array!');
        }
    }

    return Course;
}


module.exports = solve;