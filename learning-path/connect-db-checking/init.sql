-- Active: 1675493335826@@127.0.0.1@3306@
CREATE DATABASE ASP_web_empty;

USE ASP_web_empty;

CREATE TABLE student (
    studentId INT PRIMARY KEY AUTO_INCREMENT,
    studentName NVARCHAR(100),
    dob DATE NOT NULL,
    imageProfile VARCHAR(300)
);

INSERT INTO `ASP_web_empty`.`student` VALUES(DEFAULT, "Pham Duc Duy", "2003/08/02", "C:\User\Admin\Downloads\images\duy.png");
INSERT INTO
    `ASP_web_empty`.`student`
VALUES
(
        DEFAULT,
        "Pham Duc Duy",
        "2002/11/02",
        "C:\User\Admin\Downloads\images\duy2.png");

INSERT INTO `ASP_web_empty`.`student`
VALUES
(
        DEFAULT,
        "Doan Quang Huy",
        "2003/11/09",
        "C:\User\Admin\Downloads\images\d_huy.png"
    );

INSERT INTO `ASP_web_empty`.`student`
VALUES
(
        DEFAULT,
        "Le Kim Phuong",
        "2003/04/11",
        "C:\User\Admin\Downloads\images\phuong.png"
    );
