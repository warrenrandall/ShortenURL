CREATE DATABASE [URL Transform]
GO
USE [URL Transform]
CREATE TABLE URLs (
   LongURL varchar(900) NOT NULL,
   ShortURL varchar(7) NOT NULL
   PRIMARY KEY(LongURL)
);
GO