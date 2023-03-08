create database DB_CW;

create table if not exists role(
    id_role int, 
    namerole varchar
);

insert into userlogin(id_userlogin, username, passwords, id_role, nameUser, phoneUser, emailUser) values 
(1, 'admin'),
(2, 'teacher'),
(3, 'student');

create table if not exists userlogin(
    id_userlogin SERIAL,
    username varchar,
    passwords varchar,
    id_role int,
    nameUser varchar,
    phoneUser varchar,
    emailUser varchar
);

insert into userlogin(username, passwords, id_role, nameUser, phoneUser, emailUser) values 
('admin', 'admin', 1, 'Dinh Viet Anh', '79263710591', 'jokerva1010123@gmail.com'),
('teacher', 'teacher', 2, 'Vu Minh Quang', '79269276275', 'vuquang@gmail.com'),
('student', 'student', 3, 'Pham Tien Manh', '79929954567', 'tienmanh@gmail.com');

create table if not exists teacher(
    id_teacher int,
    id_userlogin int,
);

insert into teacher(id_teacher, id_userlogin) values 
(1, 2);

create table if not exists student(
    id_student int,
    id_userlogin int,
    class varchar
);

insert into student(id_student, id_userlogin, class) values 
(1, 3, '10A1');

create table if not exists subject(
    id_subject int,
    namesubject varchar
);

create table if not exists tea_sub(
    id_teacher int,
    id_subject int
);

create table if not exists questions(
    id_question int, 
    id_mon int,
    question varchar,
    correct_ans int,
    ans_A varchar,
    ans_B varchar,
    ans_C varchar,
    ans_D varchar
);

create table if not exists exams(
    id_exam int, 
    id_mon int,
    nameExam varchar,
);

create table if not exists history(
    id_history int,
    id_exam int, 
    id_student int,
    result int, 
    timedone DATE
);