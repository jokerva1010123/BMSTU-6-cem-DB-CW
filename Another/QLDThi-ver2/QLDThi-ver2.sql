create database QLDThiVer2

create table tblUser(
	id int identity(1,1) not null primary key,
	name nvarchar (40) not null,
	username varchar (20) not null,
	pass_word varchar (max) not null,
	role varchar (1),
	status bit default 1
)

create table tblExam(
	 id int identity(1,1) not null primary key,
	 subjectId int null,
	 code nvarchar (10) not null,
	 listQuestionId varchar (max),
 )

create table tblQuestion(
	 id int identity(1,1) not null primary key,
	 subjectId int null,
	 question nvarchar (max) not null,
	 listAnswer nvarchar (max),
	 correctAnswer nvarchar (max),
 )

 create table tblSubject(
	 id int identity(1,1) not null primary key,
	 name nvarchar (40),
 )

 create table tblExam_Question(
	 id int identity(1,1) not null primary key,
	 examId int not null,
	 questionId int not null,
 )

  create table tblResult(
	 id int identity(1,1) not null primary key,
	 examId int not null,
	 userId int not null,
	 startTime varchar(50) null,
	 endTime varchar(50) null,
	 score int null,
 );

  create table tblSubject(
	 id int identity(1,1) not null primary key,
	 name nvarchar (40),
 )

ALTER TABLE tblSubject ADD status int default 1
ALTER TABLE tblExam ADD DEFAULT(1) FOR status

 /*tạo proc đăng ký */
create proc CreateUser 
@username varchar(20), 
@password varchar(max),
@name varchar(40),
@role varchar(1)
as
begin
    insert into tblUser (username,pass_word, name, role)
	values (@username,@password, @name, @role)
end

/*tạo proc sửa ng dùng */
create proc EditUser 
@id int,
@username varchar(20), 
@name varchar(40)
as
update tblUser
set username = @username , name = @name
where id = @id

 /*tạo proc xóa ng dùng */
create proc DeleteUser 
@id int
as 
update tblUser
set status = 0
WHERE id = @id

/*tạo proc lấy danh sách ng dùng */
create proc GetListUser
@role varchar(1)
as 
select id, name, username, status from tblUser where role = @role and status = 1

exec GetListUser "A"


/*tạo proc tìm kiếm ng dùng */
create or alter proc SearchUser
@keyword varchar
as 
select id, name, username from tblUser 
where (username like '%'+@keyword+'%') and status = 1

/*tạo proc kiểm tra đăng nhập */
create proc LoginCheck 
@username varchar(20)
as
select id, username, pass_word, role
from tblUser 
where username=@username 

/*tạo proc kiểm tra người dùng tồn tại */
create proc CheckExistUser @username varchar(20)
as
select username 
from tblUser 
where username=@username

/*tạo proc đổi mật khẩu */
create proc ChangePW 
@id int,
@password varchar (max)
as
update tblUser
set pass_word = @password 
where id = @id

/*tạo proc reset mật khẩu */
create proc ResetPW 
@id int,
@password varchar (max)
as
update tblUser
set pass_word = @password 
where id = @id

 /*tạo proc soạn câu hỏi */
create proc addQuestion
@question nvarchar(max), 
@listAnswer nvarchar(max), 
@correctAnswer nvarchar(max),
@subjectId int
as
insert into tblQuestion (question, listAnswer, correctAnswer, subjectId)
values (@question, @listAnswer, @correctAnswer, @subjectId)

/*tạo proc lấy danh sách câu hỏi */
create proc getListQuestion
as 
select tblQuestion.id, subjectId, question, listAnswer, correctAnswer, tblSubject.name as subjectName from tblQuestion join tblSubject 
on tblQuestion.subjectId = tblSubject.id
where tblQuestion.status = 1

exec getListQuestion

 /* Lấy danh sách câu hỏi theo môn học */
 create proc getListQuestionBySubject
 @subjectId int
 as 
 select id, question, listAnswer, correctAnswer, subjectId from tblQuestion 
 where status = 1 and subjectId = @subjectId

 exec getListQuestionBySubject 1

/*proc sửa câu hỏi*/ 
create proc editQuestion 
@id int,
@question nvarchar (max),
@listAnswer nvarchar (max),
@correctAnswer nvarchar(max),
@subjectId int
as 
update tblQuestion
set question = @question, listAnswer = @listAnswer, correctAnswer = @correctAnswer, subjectId = @subjectId
WHERE id = @id

/*proc xóa câu hỏi*/
create proc deleteQuestion 
@id int
as 
update tblQuestion
set status = 0
WHERE id = @id

/*proc kiểm tra mã đề thi*/
create proc CheckExistExam @code nvarchar(10)
as
select code 
from tblExam
where code=@code

/*proc thêm mới đề thi*/
create proc addExam 
@code nvarchar(10),
@listQuestionId varchar(max),
@subjectId int
as
insert into tblExam(code, listQuestionId, subjectId)
values (@code, @listQuestionId, @subjectId)

/*tạo proc lấy danh sách câu hỏi */
create proc getListExam
as 
select tblExam.id, subjectId, code, listQuestionId, tblSubject.name as subjectName from tblExam join tblSubject 
on tblExam.subjectId = tblSubject.id
where tblExam.status = 1

/*proc sửa câu hỏi*/ 
CREATE proc editExam 
@id int,
@listQuestionId nvarchar (max)
as 
update tblExam
set listQuestionId = @listQuestionId
WHERE id = @id

/*proc xóa câu hỏi*/
create proc deleteExam
@id int
as 
update tblExam
set status = 0
WHERE id = @id

/*proc lấy chi tiết câu hỏi*/
create proc getQuestionById
@id int
as 
BEGIN
  SELECT *
  FROM tblQuestion
  where tblQuestion.id = @id
END

EXEC getQuestionById @id = 3

/*proc thêm mới kết quả thi*/
create proc addResult
@userId int,
@examId int,
@score int,
@totalScore int,
@startTime varchar(50),
@endTime varchar(50)
as
insert into tblResult(userId, examId, score, startTime, endTime, totalScore)
values (@userId, @examId, @score, @startTime, @endTime, @totalScore)

/*tạo proc lấy danh sách kết quả */
create proc getListResult
@userId int
as 
select tblExam.code, startTime, endTime, score, totalScore, tblUser.name
from tblResult inner join tblExam
on tblResult.examId = tblExam.id 
inner join tblUser on tblResult.userId = tblUser.id 
where userId = @userId

exec getListResult 6

/*tạo proc lấy danh sách kết quả */
create proc getListResultAdmin
as 
select tblExam.code, startTime, endTime, score, totalScore, tblUser.name
from tblResult inner join tblExam
on tblResult.examId = tblExam.id 
inner join tblUser on tblResult.userId = tblUser.id 

/* Lấy danh sách môn học */
 create proc getListSubject
 as 
 select id, name from tblSubject where status = 1

 /* Tạo môn học */
 create proc createSubject
@name nvarchar(40)
as
insert into tblSubject(name)
values (@name)

/* Sửa câu hỏi */
create proc editSubject 
@id int, 
@name varchar(40)
as
update tblSubject
set name = @name
where id = @id

/* Xóa câu hỏi */
create proc deleteSubject 
@id int
as 
update tblSubject
set status = 0
where id = @id

/* Tìm kiếm câu hỏi */
create proc searchSubject
@keyword varchar
as 
select id, name from tblSubject 
where name like '%'+@keyword+'%' and status = 1

select id, name from tblSubject 
where name like '%Math%' and status = 1

exec searchSubject 'Math'






INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Hội văn hoá cứu quốc được thành lập vào thời gian nào?', N'[năm 1941, năm 1943, năm 1944, năm 1945]' , N'năm 1941');

INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Chiến khu Hoà - Ninh - Thanh còn có tên là gì?', N'[Trần Hưng Đạo, Hoàng Hoa Thám, Lê Lợi, Quang Trung]' , N'Quang Trung');

INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Trong cao trào kháng Nhật cứu nước, phong trào "Phá kho thóc của Nhật để giải quyết nạn đói" đã diễn ra mạnh mẽ ở đâu?', N'[Đồng bằng Nam Bộ, Đồng bằng Nam Bộ, Đồng bằng Bắc Bộ, Đồng bằng Trung Bộ]' , N'Đồng bằng Bắc Bộ');

INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Hội nghị quân sự cách mạng Bắc kỳ họp vào thời gian nào?', N'[tháng 3-1945, tháng 4-1945, tháng 5-1945, tháng 6-1945]' , N'tháng 5-1945');

INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Uỷ ban dân tộc giải phóng do ai làm chủ tịch?', N'[Hồ Chí Minh, Trường Chinh, Phạm Văn Đồng, Võ Nguyên Giáp]' , N'Trường Chinh');

INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Sau ngày tuyên bố độc lập Chính phủ lâm thời đã xác định các nhiệm vụ cấp bách cần giải quyết:', N'[Chống ngoại xâm, Chống ngoại xâm và nội phản, Diệt giặc đói, giặc dốt và giặc ngoại xâm, Cả ba phương án trên]' , N'Cả ba phương án trên');

INSERT INTO tblQuestion (question, listAnswer, correctAnswer) 
VALUES (N'Hội văn hoá cứu quốc được thành lập vào thời gian nào?', N'[năm 1941, năm 1943, năm 1944, năm 1945]' , N'năm 1941');


insert into tblUser(username, pass_word, name, role)
values ('admin', '$2a$11$WN7W9ugt6kNcF7Jaany.p.6PmaImbSzkhiYufDr4DTupcTLltzeJW', 'Admin', 'A')

