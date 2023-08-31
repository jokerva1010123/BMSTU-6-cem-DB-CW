,--create database db_cw;
drop table if exists Users;
drop table if exists Exams;
drop table if exists Questions;
drop table if exists Exam_Question;
drop table if exists Subjects;
drop table if exists Results;
create table if not exists  Users(
	id serial not null primary key,
	name varchar not null,
	username varchar not null,
	pass_word varchar not null,
	role varchar
);

create table if not exists Subjects(
	id_subject serial not null primary key,
	name varchar
);

create table if not exists Exams(
	id_exam serial not null primary key,
	id_subject int null,
	name_exam varchar not null,
	code_exam varchar not null,
	duration integer not null,
	FOREIGN KEY (id_subject) REFERENCES Subjects(id_subject)
);

create table if not exists Questions(
	id_question serial not null primary key,
	id_subject int null,
	question varchar not null,
	answer1 varchar,
	answer2 varchar,
	answer3 varchar,
	answer4 varchar,
	answer varchar,
	FOREIGN KEY (id_subject) REFERENCES Subjects(id_subject)
);

create table if not exists Exam_Question(
	id_examQuestion serial not null primary key,
	id_exam int not null,
	id_question int not null,
	FOREIGN KEY (id_exam) REFERENCES Exams(id_exam),
	FOREIGN KEY (id_question) REFERENCES Questions(id_question)
);

create table if not exists Results(
	id_result serial not null primary key,
	id_exam int not null,
	id_user int not null,
	startTime varchar null,
	endTime varchar null,
	score int null,
	totalScore int null,
	FOREIGN KEY (id_exam) REFERENCES Exams(id_exam),
	FOREIGN KEY (id_user) REFERENCES Users(id)
);



insert into Users(username, pass_word, name, role)
values ('admin', 'Abcd@123', 'admin', 'A'),
('teacher', 'Abcd@123', 'teacher', 'T'),
('vanh', 'Abcd@123', 'vanh', 'A');

insert into Subjects(name)
values ('Information'),
('Math'),
('History');

select * from Users;
select * from Subjects where name like '%И%';
select * from exam_question;
select * from exams;
insert into exam_question(id_exam, id_question) values (1, 8);
insert into Results(id_user, id_exam, starttime, endtime, score, totalscore)
values (6, 1, 'Jan 01 2023 20:20', 'Jan 01 2023 20:30', 10, 30);
insert into Exams(id_subject, name_exam, code_exam)
values (1, 'test 1', 'abc');

--create user role
CREATE ROLE adminuser WITH
	LOGIN
	NOSUPERUSER
	NOCREATEDB
	NOREPLICATION
	PASSWORD 'Admin@123'
	CONNECTION LIMIT -1;
GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA PUBLIC TO adminuser;

CREATE ROLE studentuser WITH
	LOGIN
	NOSUPERUSER
	NOCREATEDB
	NOREPLICATION
	CONNECTION LIMIT -1;
GRANT SELECT ON public.exams TO studentuser;
GRANT SELECT ON public.results TO studentuser ;

CREATE ROLE teacheruser WITH
	LOGIN
	NOSUPERUSER
	NOCREATEDB
	NOREPLICATION
	PASSWORD 'Teacher@123'
	CONNECTION LIMIT -1;
GRANT SELECT ON public.exams TO teacheruser;
GRANT SELECT ON public.results TO teacheruser;
GRANT SELECT ON public.questions TO teacheruser;
GRANT SELECT ON public.exam_question TO teacheruser;

GRANT INSERT ON public.exams TO teacheruser;
GRANT INSERT ON public.questions TO teacheruser;
GRANT INSERT ON public.exam_question TO teacheruser;

GRANT DELETE ON public.exams TO teacheruser;
GRANT DELETE ON public.questions TO teacheruser;
GRANT DELETE ON public.exam_question TO teacheruser;