create database DB_CW;
create table if not exists userlogin(
    username varchar,
    passwords varchar,
    typeuser int
);

insert into userlogin(username, passwords, typeuser) values 
('admin', 'admin', 0),
('teacher', 'teacher', 1),
('student', 'student', 2);

create table if not exists teacher(
    id int,
    nameTeacher varchar,
    username varchar unique,
    passwords varchar
);

insert into teacher(id, nameTeacher, username, passwords) values 
(1, 'Dinh Viet Anh', 'teacher', 'teacher');

create table if not exists student(
    id int,
    nameStudent varchar,
    username varchar,
    passwords varchar
);

insert into student(id, nameStudent, username, passwords) values 
(1, 'Pham Tien Manh', 'student', 'student');