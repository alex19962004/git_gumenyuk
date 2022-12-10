CREATE TABLE testdb.Students
(
    Id      int,
    Name    varchar(255),
    Surname varchar(255),

    PRIMARY KEY (Id)
);

CREATE TABLE testdb.Books
(
    Id        int,
    Title     varchar(255),
    StudentId int,

    PRIMARY KEY (Id),
    FOREIGN KEY (StudentId) REFERENCES testdb.Students (Id)
);

CREATE TABLE testdb.Lessons
(
    Id          int,
    Description varchar(255),

    PRIMARY KEY (Id)
);

CREATE TABLE testdb.StudentToLesson
(
    StudentId int,
    LessonId  int,

    FOREIGN KEY (StudentId) REFERENCES testdb.Students (Id),
    FOREIGN KEY (LessonId) REFERENCES testdb.Lessons (Id)
);

INSERT INTO testdb.Students
VALUES (1, "Andrii", "Dudb");
INSERT INTO testdb.Students
VALUES (2, "Alex", "Fomich");

INSERT INTO testdb.Books
VALUES (100, "Title1", 1);
INSERT INTO testdb.Books
VALUES (101, "Title2", 2);

INSERT INTO testdb.Lessons
VALUES (300, "Geographi");
INSERT INTO testdb.Lessons
VALUES (302, "Math");

INSERT INTO testdb.StudentToLesson
VALUES (1, 300);
INSERT INTO testdb.StudentToLesson
VALUES (1, 302);

/*INSERT INTO testdb.StudentToLesson VALUES(2, "Math");*/

