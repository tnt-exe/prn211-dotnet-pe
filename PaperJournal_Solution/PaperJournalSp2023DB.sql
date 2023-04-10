USE master
GO

CREATE DATABASE PaperJournalSp2023DB
GO

USE PaperJournalSp2023DB
GO

CREATE TABLE Account 
(
 StaffID nvarchar(50) PRIMARY KEY,
 AccountFullName nvarchar(60) NOT NULL,
 AccountEmail nvarchar(50) NOT NULL, 
 AccountPassword nvarchar(50), 
 Birthday Datetime NOT NULL,
 AccountRole int
);
GO

INSERT INTO Account VALUES ('ACC0055', 'Admin', 'admin@SpringerLink.com','@abc',CAST(N'1990-03-25' AS DateTime), 0);
INSERT INTO Account VALUES ('ACC0006', 'HR Manager 1', 'manager1@SpringerLink.com','@123', CAST(N'1991-09-12' AS DateTime), 1);
INSERT INTO Account VALUES ('ACC0009', 'HR Manager 2', 'manager2@SpringerLink.com','@123', CAST(N'1992-08-11' AS DateTime), 1);
INSERT INTO Account VALUES ('ACC0007', 'Staff', 'staff@SpringerLink.com','123@', CAST(N'1990-04-20' AS DateTime), 2);
GO

CREATE TABLE JournalInfo(
  JournalID int PRIMARY KEY,
  JournalName nvarchar(120) NOT NULL,
  ShortJournalDescription nvarchar(250), 
  Telephone nvarchar(20), 
  Category nvarchar(100)
)
GO

INSERT INTO JournalInfo VALUES (4440, N'International Journal of Computational Vision and Robotics ', N'IJCVR is an international refereed journal in the field of image processing, pattern recognition, machine vision and image understanding, providing an international forum for professionals, engineers and researchers.','1880903914555',N'Computer Science, AI, Data Mining');
INSERT INTO JournalInfo VALUES (4441, N'International Journal of Data Analysis Techniques and Strategies', N'IJDATS bridges three gaps: firstly, a gap between academic ivory tower and the real world; secondly, a gap between quantitative data analysis techniques and qualitative data analysis techniques;','1880903914555',N'Data Science, Data Mining, AI');
INSERT INTO JournalInfo VALUES (4450, N'International Journal of Information and Coding Theory', N'IJICoT publishes state-of-the-art international research that significantly advances the study of information and coding theory and their applications to cryptography, ... ','1880903914555',N'Information System, AI, Machine Learning');
INSERT INTO JournalInfo VALUES (4460, N'International Journal of Artificial Intelligence and Soft Computing', N'IJAISC provides a new forum for dissemination of knowledge on both theoretical and applied research on artificial intelligence.','1880903914555',N'AI, Optimization Problem');
INSERT INTO JournalInfo VALUES (4476, N'International Journal of Intelligent Information and Database Systems', N'IJIIDS focuses on research in applications of advanced intelligent technologies for data storing/processing in a wide-ranging context.','1880903914555',N'Database, IS, AI');
GO

CREATE TABLE Paper(
 PaperID nvarchar(20) PRIMARY KEY,
 PaperTitle nvarchar(100) NOT NULL,
 SubmittedDate Datetime NOT NULL,
 Abstract nvarchar(MAX) NOT NULL,
 Authors nvarchar(150),
 JournalID int REFERENCES JournalInfo(JournalID) ON DELETE CASCADE ON UPDATE CASCADE)
GO


INSERT INTO Paper VALUES (N'PP0020',N'A hybrid approach for improving data classification based on PCA and enhanced ELM',CAST(N'2022-05-18' AS DateTime), N'The efficient and effective process of extracting the useful information from high-dimensional data is worth studying. High-dimensional data is big and complex and that it becomes difficult process and classify. Dimensionality reduction (DR) is important and the key method to address these problems. This paper presents a hybrid approach for data classification constituted from the combination of principal component analysis (PCA) and enhanced extreme learning machine (EELM).', N'Doaa L. El-Bably; Khaled M. Fouad', 4476);
GO

INSERT INTO Paper VALUES (N'PP0021',N'An enhanced secure data aggregation routing protocol for sensor networks',CAST(N'2022-06-11' AS DateTime), N'For the past decade, the utilisation of sensor devices in real world applications has increased rapidly. To meet the demand of applications, the sensor nodes are deployed in remote areas where the operation is very complex. The security of the sensor nodes may be compromised at any time. Therefore, a secure data aggregation mechanism is needed to overcome their limitations.', N'A.L. Sreenivasulu; P. Chenna Reddy', 4476);
GO

INSERT INTO Paper VALUES (N'PP0022',N'Student absenteeism in engineering college using rough set and data mining approach',CAST(N'2022-07-05' AS DateTime), N'Now-a-days student absenteeism in engineering education is a most important issue of a professional institution which affects the overall performance of institutions. This is most imperative alarm in creating outstanding engineers (real engineers) to the country. The quality of education is directly proportional to student absenteeism. ', N'I. Samuel Peter James; P. Ramasubramanian; D. Magdalene Delighta Angeline', 4476);
GO

INSERT INTO Paper VALUES (N'PP0023',N'Prediction of exchange rate using improved particle swarm optimised radial basis function networks',CAST(N'2022-08-19' AS DateTime), N'In this paper, a radial basis function neural network (RBFN) model has been trained by canonical particle swarm optimisation (PSO) and improved particle swarm optimisation (IMPSO) algorithms to efficiently predict the exchange rate of Indian rupees against the exchange rate of G-7 countries for future days.', N'Trilok Nath Pandey; Alok Kumar Jagadev; Satchidananda Dehuri; Sung-Bae Cho', 4476);
GO

INSERT INTO Paper VALUES (N'PP0024',N'Copy-move image forgery detection using cuckoo search',CAST(N'2022-08-20' AS DateTime), N'Most people face the dilemma of accepting photographs as authentic or not, mainly in the case of forensics, where the images will influence judgment. Research communities are constantly providing methods to identify these kinds of forged images.', N'Tarun Kumar; Gourav Khurana', 4441);
GO

INSERT INTO Paper VALUES (N'PP0015',N'Rice plant disease, crop stages endemic and control measures - a survey',CAST(N'2022-09-01' AS DateTime), N'Plant diseases are the main cause of economic losses in the agricultural field. In India, the most significant staple food consumed is rice. Different kinds of disease of rice namely grain discoloration, sheath blight, brown spot, and blast are the main restriction on rice harvesting or production and explosion being the most demoralising disease.', N'T. Gayathri Devi; P. Neelamegam; A. Srinivasan', 4441);
GO

INSERT INTO Paper VALUES (N'PP0027',N'Application of fuzzy logic on CT-scan images of COVID-19 patients',CAST(N'2022-10-17' AS DateTime), N'Image processing is crucial in any image analysis to determine the problem. If it is a medical area, a suitable image processing method becomes even more imperative to get as accurate results as possible. Due to the widespread outbreak of coronavirus disease 2019 (COVID-19), an infectious respiratory disease, it has become quite urgent that a reliable method for identification of the disease is sought.', N'Fariha Noor; Md. Rashad Tanjim; Muhammad Jawadur Rahim; Md. Naimul Islam Suvon; Faria Karim Porna;', 4441);
GO