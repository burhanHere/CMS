USE CMS_DP_Project;
#temp data in tables:
INSERT INTO Courses (CourseName, AssignmentWeightage, QuizWeightage, MidWeightage, FinalWeightage)
VALUES
    ('DLD', 15, 20, 25, 40),
    ('ITC', 20, 15, 25, 40),
    ('PF', 20, 15, 25, 40),
    ('DSA', 10, 15, 30, 45),
    ('OOP', 10, 15, 30, 45);

INSERT INTO Sections (SectionName, CourseName)
VALUES
    ('B11', 'DLD'), ('B12', 'DLD'), ('B13', 'DLD'), ('A11', 'ITC'), ('A12', 'ITC'), ('A13', 'ITC'), ('A14', 'PF'), ('B6', 'PF'), ('B7', 'PF'),
    ('B8', 'DSA'), ('D6', 'DSA'), ('D14', 'DSA'), ('D36', 'OOP'), ('D16', 'OOP'), ('D2', 'OOP'), ('D12', 'OOP'), ('C8', 'OOP');

INSERT INTO Students(StudentID, StudentName)
VALUES
	('l1f21bscs1059', 'Muhammad Burhan'),('l1f21bscs0485', 'Areeba Khan'),('l1f21bscs1060', 'Sarah Ahmed'),('l1f21bscs1061', 'Ali Khan'),('l1f21bscs1062', 'Aisha Hassan'),
    ('l1f21bscs1063', 'Ahmed Malik'),('l1f21bscs1064', 'Sana Ahmed'),('l1f21bscs1065', 'Mohammad Ali'),('l1f21bscs1066', 'Hina Khan'),('l1f21bscs1067', 'Omar Farooq'),
    ('l1f21bscs1068', 'Fatima Shah'),('l1f21bscs1069', 'Usman Akram'),('l1f21bscs1070', 'Zainab Riaz'),('l1f21bscs1071', 'Hassan Abbas'),('l1f21bscs1072', 'Sara Khan'),
    ('l1f21bscs1073', 'Muhammad Iqbal'),('l1f21bscs1074', 'Ayesha Qureshi'),('l1f21bscs1075', 'Ahmed Raza'),('l1f21bscs1076', 'Madiha Malik'),('l1f21bscs1077', 'Bilal Ahmed'),
    ('l1f21bscs1078', 'Maria Khan'),('l1f21bscs1079', 'Hamza Ali'),('l1f21bscs1080', 'Sadia Ahmed'),('l1f21bscs1081', 'Kamran Khan'),('l1f21bscs1082', 'Nida Malik'),
    ('l1f21bscs1083', 'Farhan Shah'),('l1f21bscs1084', 'Ayesha Khan'),('l1f21bscs1085', 'Bilal Mahmood'),('l1f21bscs1086', 'Hina Raza'),('l1f21bscs1087', 'Waqar Ahmed'),
    ('l1f21bscs1088', 'Sara Akram'),('l1f21bscs1089', 'Asad Ali'),('l1f21bscs1090', 'Aisha Malik'),('l1f21bscs1091', 'Usman Khan'),('l1f21bscs1092', 'Zara Ahmed'),
    ('l1f21bscs1093', 'Rizwan Hassan'),('l1f21bscs1094', 'Hira Qureshi'),('l1f21bscs1095', 'Imran Riaz'),('l1f21bscs1096', 'Fariha Khan'),('l1f21bscs1097', 'Kashif Mahmood'),
    ('l1f21bscs1098', 'Samina Malik'),('l1f21bscs1099', 'Noman Akhtar'),('l1f21bscs1100', 'Sadaf Raza'),('l1f21bscs1101', 'Tahir Ahmed'),('l1f21bscs1102', 'Amina Khan'),
    ('l1f21bscs1103', 'Asif Ali'),('l1f21bscs1104', 'Rabia Hassan'),('l1f21bscs1105', 'Arslan Qureshi'),('l1f21bscs1106', 'Hafsa Riaz'),('l1f21bscs1107', 'Junaid Malik'),
    ('l1f21bscs1108', 'Saima Ahmed'),('l1f21bscs1109', 'Mudassir Khan'),('l1f21bscs1110', 'Iqra Malik'),('l1f21bscs1111', 'Ahmed Ali'),('l1f21bscs1112', 'Maryam Hassan'),
    ('l1f21bscs1113', 'Omar Qureshi'),('l1f21bscs1114', 'Fiza Riaz'),('l1f21bscs1115', 'Bilal Raza'),('l1f21bscs1116', 'Sadia Malik'),('l1f21bscs1117', 'Zain Khan'),
    ('l1f21bscs1118', 'Ayesha Ahmed'),('l1f21bscs1119', 'Nadeem Mahmood'),('l1f21bscs1120', 'Hira Akhtar'),('l1f21bscs1121', 'Adnan Raza'),('l1f21bscs1122', 'Syed Safiullah'),
    ('l1f21bscs1123', 'Saad Qureshi'),('l1f21bscs1124', 'Sana Riaz'),('l1f21bscs1125', 'Kamran Malik'),('l1f21bscs1126', 'Fariha Ahmed'),('l1f21bscs1127', 'Ahmed Khan'),
    ('l1f21bscs1128', 'Nida Raza');

INSERT INTO DivideInto (StudentID, SectionName)
VALUES
    ('l1f21bscs1059', 'B11'), ('l1f21bscs0485', 'B12'), ('l1f21bscs1060', 'B13'), ('l1f21bscs1061', 'A11'), ('l1f21bscs1062', 'A12'), 
    ('l1f21bscs1063', 'A13'), ('l1f21bscs1064', 'A14'), ('l1f21bscs1065', 'B6'), ('l1f21bscs1066', 'B7'), ('l1f21bscs1067', 'B8'), 
    ('l1f21bscs1068', 'D6'), ('l1f21bscs1069', 'D14'), ('l1f21bscs1070', 'D36'), ('l1f21bscs1071', 'D16'), ('l1f21bscs1072', 'D2'), 
    ('l1f21bscs1073', 'D12'), ('l1f21bscs1074', 'C8'), ('l1f21bscs1075', 'C8'), ('l1f21bscs1076', 'C8'), ('l1f21bscs1077', 'C8'),
    ('l1f21bscs1078', 'C8'), ('l1f21bscs1079', 'C8'), ('l1f21bscs1080', 'B11'), ('l1f21bscs1081', 'B12'), ('l1f21bscs1082', 'B13'), 
    ('l1f21bscs1083', 'A11'), ('l1f21bscs1084', 'A12'), ('l1f21bscs1085', 'A13'), ('l1f21bscs1086', 'A14'), ('l1f21bscs1087', 'B6'), 
    ('l1f21bscs1088', 'B7'), ('l1f21bscs1089', 'B8'), ('l1f21bscs1090', 'D6'), ('l1f21bscs1091', 'D14'), ('l1f21bscs1092', 'D36'), 
    ('l1f21bscs1093', 'D16'), ('l1f21bscs1094', 'D2'), ('l1f21bscs1095', 'D12'), ('l1f21bscs1096', 'C8'), ('l1f21bscs1097', 'B13'), 
    ('l1f21bscs1098', 'B13'), ('l1f21bscs1099', 'B13'), ('l1f21bscs1100', 'B13'), ('l1f21bscs1101', 'B13'), ('l1f21bscs1102', 'B11'), 
    ('l1f21bscs1103', 'B12'), ('l1f21bscs1104', 'B13'), ('l1f21bscs1105', 'A11'), ('l1f21bscs1106', 'A12'), ('l1f21bscs1107', 'A13'), 
    ('l1f21bscs1108', 'A14'), ('l1f21bscs1109', 'B6'), ('l1f21bscs1110', 'B7'), ('l1f21bscs1111', 'B8'), ('l1f21bscs1112', 'D6'), 
    ('l1f21bscs1113', 'D14'), ('l1f21bscs1114', 'D36'), ('l1f21bscs1115', 'D16'), ('l1f21bscs1116', 'D2'), ('l1f21bscs1117', 'D12'), 
    ('l1f21bscs1118', 'C8'), ('l1f21bscs1119', 'D36'), ('l1f21bscs1120', 'D36'),('l1f21bscs1121', 'A11'), ('l1f21bscs1122', 'A11'),     
    ('l1f21bscs1123', 'B12'), ('l1f21bscs1124', 'B11'), ('l1f21bscs1125', 'B12'), ('l1f21bscs1126', 'B13'), ('l1f21bscs1127', 'A11'),('l1f21bscs1128', 'A12');

INSERT INTO Assignments (DateCommenced, TotalMarks, ObtainedMarks, SectionName, StudentID)
VALUES
    ('2023-05-20', 10, 9, 'B11', 'l1f21bscs1059'),('2023-05-20', 10, 8, 'B12', 'l1f21bscs0485'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1060'),
    ('2023-05-20', 10, 8, 'A11', 'l1f21bscs1061'),('2023-05-20', 10, 7, 'A12', 'l1f21bscs1062'),('2023-05-20', 10, 9, 'A13', 'l1f21bscs1063'),
    ('2023-05-20', 10, 8, 'A14', 'l1f21bscs1064'),('2023-05-20', 10, 9, 'B6', 'l1f21bscs1065'),('2023-05-20', 10, 8, 'B7', 'l1f21bscs1066'),
    ('2023-05-20', 10, 9, 'B8', 'l1f21bscs1067'),('2023-05-20', 10, 8, 'D6', 'l1f21bscs1068'),('2023-05-20', 10, 9, 'D14', 'l1f21bscs1069'),
    ('2023-05-20', 10, 8, 'D36', 'l1f21bscs1070'),('2023-05-20', 10, 9, 'D16', 'l1f21bscs1071'),('2023-05-20', 10, 8, 'D2', 'l1f21bscs1072'),
    ('2023-05-20', 10, 9, 'D12', 'l1f21bscs1073'),('2023-05-20', 10, 9, 'C8', 'l1f21bscs1074'),('2023-05-20', 10, 8, 'C8', 'l1f21bscs1075'),
    ('2023-05-20', 10, 9, 'C8', 'l1f21bscs1076'),('2023-05-20', 10, 8, 'C8', 'l1f21bscs1077'),('2023-05-20', 10, 9, 'C8', 'l1f21bscs1078'),
    ('2023-05-20', 10, 8, 'C8', 'l1f21bscs1079'),('2023-05-20', 10, 9, 'B11', 'l1f21bscs1080'),('2023-05-20', 10, 8, 'B12', 'l1f21bscs1081'),
    ('2023-05-20', 10, 9, 'B13', 'l1f21bscs1082'),('2023-05-20', 10, 8, 'A11', 'l1f21bscs1083'),('2023-05-20', 10, 9, 'A12', 'l1f21bscs1084'),
    ('2023-05-20', 10, 8, 'A13', 'l1f21bscs1085'),('2023-05-20', 10, 9, 'A14', 'l1f21bscs1086'),('2023-05-20', 10, 8, 'B6', 'l1f21bscs1087'),
    ('2023-05-20', 10, 9, 'B7', 'l1f21bscs1088'),('2023-05-20', 10, 8, 'B8', 'l1f21bscs1089'),('2023-05-20', 10, 9, 'D6', 'l1f21bscs1090'),
    ('2023-05-20', 10, 8, 'D14', 'l1f21bscs1091'),('2023-05-20', 10, 9, 'D36', 'l1f21bscs1092'),('2023-05-20', 10, 8, 'D16', 'l1f21bscs1093'),
    ('2023-05-20', 10, 9, 'D2', 'l1f21bscs1094'),('2023-05-20', 10, 8, 'D12', 'l1f21bscs1095'),('2023-05-20', 10, 9, 'C8', 'l1f21bscs1096'),
    ('2023-05-20', 10, 8, 'B13', 'l1f21bscs1097'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1098'),('2023-05-20', 10, 8, 'B13', 'l1f21bscs1099'),
    ('2023-05-20', 10, 9, 'B13', 'l1f21bscs1100'),('2023-05-20', 10, 8, 'B13', 'l1f21bscs1101'),('2023-05-20', 10, 9, 'B11', 'l1f21bscs1102'),
    ('2023-05-20', 10, 8, 'B12', 'l1f21bscs1103'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1104'),('2023-05-20', 10, 8, 'A11', 'l1f21bscs1105'),
    ('2023-05-20', 10, 9, 'A12', 'l1f21bscs1106'),('2023-05-20', 10, 8, 'A13', 'l1f21bscs1107'),('2023-05-20', 10, 9, 'A14', 'l1f21bscs1108'),
    ('2023-05-20', 10, 8, 'B6', 'l1f21bscs1109'),('2023-05-20', 10, 9, 'B7', 'l1f21bscs1110'),('2023-05-20', 10, 8, 'B8', 'l1f21bscs1111'),
    ('2023-05-20', 10, 9, 'D6', 'l1f21bscs1112'),('2023-05-20', 10, 8, 'D14', 'l1f21bscs1113'),('2023-05-20', 10, 9, 'D36', 'l1f21bscs1114'),
    ('2023-05-20', 10, 8, 'D16', 'l1f21bscs1115'),('2023-05-20', 10, 9, 'D2', 'l1f21bscs1116'),('2023-05-20', 10, 8, 'D12', 'l1f21bscs1117'),
    ('2023-05-20', 10, 9, 'C8', 'l1f21bscs1118'),('2023-05-20', 10, 8, 'D36', 'l1f21bscs1119'),('2023-05-20', 10, 9, 'D36', 'l1f21bscs1120'),
    ('2023-05-20', 10, 8, 'A11', 'l1f21bscs1121'),('2023-05-20', 10, 9, 'A11', 'l1f21bscs1122'),('2023-05-20', 10, 8, 'B13', 'l1f21bscs1123'),
    ('2023-05-20', 10, 9, 'B11', 'l1f21bscs1124'),('2023-05-20', 10, 8, 'B12', 'l1f21bscs1125'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1126'),
    ('2023-05-20', 10, 8, 'A11', 'l1f21bscs1127'),('2023-05-20', 10, 9, 'A12', 'l1f21bscs1128');

INSERT INTO Quizes (DateCommenced, TotalMarks, ObtainedMarks, SectionName, StudentID)
VALUES
    ('2023-05-20', 10, 9, 'B11', 'l1f21bscs1059'),('2023-05-20', 10, 8, 'B12', 'l1f21bscs0485'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1060'),
    ('2023-05-20', 10, 8, 'A11', 'l1f21bscs1061'),('2023-05-20', 10, 7, 'A12', 'l1f21bscs1062'),('2023-05-20', 10, 9, 'A13', 'l1f21bscs1063'),
    ('2023-05-20', 10, 8, 'A14', 'l1f21bscs1064'),('2023-05-20', 10, 9, 'B6', 'l1f21bscs1065'),('2023-05-20', 10, 8, 'B7', 'l1f21bscs1066'),
    ('2023-05-20', 10, 9, 'B8', 'l1f21bscs1067'),('2023-05-20', 10, 8, 'D6', 'l1f21bscs1068'),('2023-05-20', 10, 9, 'D14', 'l1f21bscs1069'),
    ('2023-05-20', 10, 8, 'D36', 'l1f21bscs1070'),('2023-05-20', 10, 9, 'D16', 'l1f21bscs1071'),('2023-05-20', 10, 8, 'D2', 'l1f21bscs1072'),
    ('2023-05-20', 10, 9, 'D12', 'l1f21bscs1073'),('2023-05-20', 10, 9, 'C8', 'l1f21bscs1074'),('2023-05-20', 10, 8, 'C8', 'l1f21bscs1075'),
    ('2023-05-20', 10, 9, 'C8', 'l1f21bscs1076'),('2023-05-20', 10, 8, 'C8', 'l1f21bscs1077'),('2023-05-20', 10, 9, 'C8', 'l1f21bscs1078'),
    ('2023-05-20', 10, 8, 'C8', 'l1f21bscs1079'),('2023-05-20', 10, 9, 'B11', 'l1f21bscs1080'),('2023-05-20', 10, 8, 'B12', 'l1f21bscs1081'),
    ('2023-05-20', 10, 9, 'B13', 'l1f21bscs1082'),('2023-05-20', 10, 8, 'A11', 'l1f21bscs1083'),('2023-05-20', 10, 9, 'A12', 'l1f21bscs1084'),
    ('2023-05-20', 10, 8, 'A13', 'l1f21bscs1085'),('2023-05-20', 10, 9, 'A14', 'l1f21bscs1086'),('2023-05-20', 10, 8, 'B6', 'l1f21bscs1087'),
    ('2023-05-20', 10, 9, 'B7', 'l1f21bscs1088'),('2023-05-20', 10, 8, 'B8', 'l1f21bscs1089'),('2023-05-20', 10, 9, 'D6', 'l1f21bscs1090'),
    ('2023-05-20', 10, 8, 'D14', 'l1f21bscs1091'),('2023-05-20', 10, 9, 'D36', 'l1f21bscs1092'),('2023-05-20', 10, 8, 'D16', 'l1f21bscs1093'),
    ('2023-05-20', 10, 9, 'D2', 'l1f21bscs1094'),('2023-05-20', 10, 8, 'D12', 'l1f21bscs1095'),('2023-05-20', 10, 9, 'C8', 'l1f21bscs1096'),
    ('2023-05-20', 10, 8, 'B13', 'l1f21bscs1097'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1098'),('2023-05-20', 10, 8, 'B13', 'l1f21bscs1099'),
    ('2023-05-20', 10, 9, 'B13', 'l1f21bscs1100'),('2023-05-20', 10, 8, 'B13', 'l1f21bscs1101'),('2023-05-20', 10, 9, 'B11', 'l1f21bscs1102'),
    ('2023-05-20', 10, 8, 'B12', 'l1f21bscs1103'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1104'),('2023-05-20', 10, 8, 'A11', 'l1f21bscs1105'),
    ('2023-05-20', 10, 9, 'A12', 'l1f21bscs1106'),('2023-05-20', 10, 8, 'A13', 'l1f21bscs1107'),('2023-05-20', 10, 9, 'A14', 'l1f21bscs1108'),
    ('2023-05-20', 10, 8, 'B6', 'l1f21bscs1109'),('2023-05-20', 10, 9, 'B7', 'l1f21bscs1110'),('2023-05-20', 10, 8, 'B8', 'l1f21bscs1111'),
    ('2023-05-20', 10, 9, 'D6', 'l1f21bscs1112'),('2023-05-20', 10, 8, 'D14', 'l1f21bscs1113'),('2023-05-20', 10, 9, 'D36', 'l1f21bscs1114'),
    ('2023-05-20', 10, 8, 'D16', 'l1f21bscs1115'),('2023-05-20', 10, 9, 'D2', 'l1f21bscs1116'),('2023-05-20', 10, 8, 'D12', 'l1f21bscs1117'),
    ('2023-05-20', 10, 9, 'C8', 'l1f21bscs1118'),('2023-05-20', 10, 8, 'D36', 'l1f21bscs1119'),('2023-05-20', 10, 9, 'D36', 'l1f21bscs1120'),
    ('2023-05-20', 10, 8, 'A11', 'l1f21bscs1121'),('2023-05-20', 10, 9, 'A11', 'l1f21bscs1122'),('2023-05-20', 10, 8, 'B13', 'l1f21bscs1123'),
    ('2023-05-20', 10, 9, 'B11', 'l1f21bscs1124'),('2023-05-20', 10, 8, 'B12', 'l1f21bscs1125'),('2023-05-20', 10, 9, 'B13', 'l1f21bscs1126'),
    ('2023-05-20', 10, 8, 'A11', 'l1f21bscs1127'),('2023-05-20', 10, 9, 'A12', 'l1f21bscs1128');    
    
INSERT INTO Mids (DateCommenced, TotalMarks, ObtainedMarks, SectionName, StudentID)
VALUES
    ('2023-05-20', 50, 39, 'B11', 'l1f21bscs1059'),('2023-05-20', 50, 42, 'B12', 'l1f21bscs0485'),('2023-05-20', 50, 39, 'B13', 'l1f21bscs1060'),('2023-05-20', 50, 42, 'A11', 'l1f21bscs1061'),
    ('2023-05-20', 50, 7, 'A12', 'l1f21bscs1062'),('2023-05-20', 50, 39, 'A13', 'l1f21bscs1063'),('2023-05-20', 50, 42, 'A14', 'l1f21bscs1064'),('2023-05-20', 50, 39, 'B6', 'l1f21bscs1065'),
    ('2023-05-20', 50, 42, 'B7', 'l1f21bscs1066'),('2023-05-20', 50, 39, 'B8', 'l1f21bscs1067'),('2023-05-20', 50, 42, 'D6', 'l1f21bscs1068'),('2023-05-20', 50, 39, 'D14', 'l1f21bscs1069'),
    ('2023-05-20', 50, 42, 'D36', 'l1f21bscs1070'),('2023-05-20', 50, 39, 'D16', 'l1f21bscs1071'),('2023-05-20', 50, 42, 'D2', 'l1f21bscs1072'),('2023-05-20', 50, 39, 'D12', 'l1f21bscs1073'),    ('2023-05-20', 50, 39, 'C8', 'l1f21bscs1074'),('2023-05-20', 50, 42, 'C8', 'l1f21bscs1075'),('2023-05-20', 50, 39, 'C8', 'l1f21bscs1076'),('2023-05-20', 50, 42, 'C8', 'l1f21bscs1077'),
    ('2023-05-20', 50, 39, 'C8', 'l1f21bscs1078'),('2023-05-20', 50, 42, 'C8', 'l1f21bscs1079'),('2023-05-20', 50, 39, 'B11', 'l1f21bscs1080'),('2023-05-20', 50, 42, 'B12', 'l1f21bscs1081'),
    ('2023-05-20', 50, 39, 'B13', 'l1f21bscs1082'),('2023-05-20', 50, 42, 'A11', 'l1f21bscs1083'),('2023-05-20', 50, 39, 'A12', 'l1f21bscs1084'),('2023-05-20', 50, 42, 'A13', 'l1f21bscs1085'),
    ('2023-05-20', 50, 39, 'A14', 'l1f21bscs1086'),('2023-05-20', 50, 42, 'B6', 'l1f21bscs1087'),('2023-05-20', 50, 39, 'B7', 'l1f21bscs1088'),('2023-05-20', 50, 42, 'B8', 'l1f21bscs1089'),
    ('2023-05-20', 50, 39, 'D6', 'l1f21bscs1090'),('2023-05-20', 50, 42, 'D14', 'l1f21bscs1091'),('2023-05-20', 50, 39, 'D36', 'l1f21bscs1092'),('2023-05-20', 50, 42, 'D16', 'l1f21bscs1093'),
    ('2023-05-20', 50, 39, 'D2', 'l1f21bscs1094'),('2023-05-20', 50, 42, 'D12', 'l1f21bscs1095'),('2023-05-20', 50, 39, 'C8', 'l1f21bscs1096'),('2023-05-20', 50, 42, 'B13', 'l1f21bscs1097'),
    ('2023-05-20', 50, 39, 'B13', 'l1f21bscs1098'),('2023-05-20', 50, 42, 'B13', 'l1f21bscs1099'),('2023-05-20', 50, 39, 'B13', 'l1f21bscs1100'),('2023-05-20', 50, 42, 'B13', 'l1f21bscs1101'),
    ('2023-05-20', 50, 39, 'B11', 'l1f21bscs1102'),('2023-05-20', 50, 42, 'B12', 'l1f21bscs1103'),('2023-05-20', 50, 39, 'B13', 'l1f21bscs1104'),('2023-05-20', 50, 42, 'A11', 'l1f21bscs1105'),
    ('2023-05-20', 50, 39, 'A12', 'l1f21bscs1106'),('2023-05-20', 50, 42, 'A13', 'l1f21bscs1107'),('2023-05-20', 50, 39, 'A14', 'l1f21bscs1108'),('2023-05-20', 50, 42, 'B6', 'l1f21bscs1109'),
    ('2023-05-20', 50, 39, 'B7', 'l1f21bscs1110'),('2023-05-20', 50, 42, 'B8', 'l1f21bscs1111'),('2023-05-20', 50, 39, 'D6', 'l1f21bscs1112'),('2023-05-20', 50, 42, 'D14', 'l1f21bscs1113'),
    ('2023-05-20', 50, 39, 'D36', 'l1f21bscs1114'),('2023-05-20', 50, 42, 'D16', 'l1f21bscs1115'),('2023-05-20', 50, 39, 'D2', 'l1f21bscs1116'),('2023-05-20', 50, 42, 'D12', 'l1f21bscs1117'),
    ('2023-05-20', 50, 39, 'C8', 'l1f21bscs1118'),('2023-05-20', 50, 42, 'D36', 'l1f21bscs1119'),('2023-05-20', 50, 39, 'D36', 'l1f21bscs1120'),('2023-05-20', 50, 42, 'A11', 'l1f21bscs1121'),
    ('2023-05-20', 50, 39, 'A11', 'l1f21bscs1122'),('2023-05-20', 50, 42, 'B13', 'l1f21bscs1123'),('2023-05-20', 50, 39, 'B11', 'l1f21bscs1124'),('2023-05-20', 50, 42, 'B12', 'l1f21bscs1125'),
    ('2023-05-20', 50, 39, 'B13', 'l1f21bscs1126'),('2023-05-20', 50, 42, 'A11', 'l1f21bscs1127'),('2023-05-20', 50, 39, 'A12', 'l1f21bscs1128');
    
INSERT INTO Final (DateCommenced, TotalMarks, ObtainedMarks, SectionName, StudentID)
VALUES
    ('2023-05-20', 70, 70, 'B11', 'l1f21bscs1059'),('2023-05-20', 70, 42, 'B12', 'l1f21bscs0485'),('2023-05-20', 70, 70, 'B13', 'l1f21bscs1060'),('2023-05-20', 70, 42, 'A11', 'l1f21bscs1061'),
    ('2023-05-20', 70, 7, 'A12', 'l1f21bscs1062'),('2023-05-20', 70, 70, 'A13', 'l1f21bscs1063'),('2023-05-20', 70, 42, 'A14', 'l1f21bscs1064'),('2023-05-20', 70, 70, 'B6', 'l1f21bscs1065'),
    ('2023-05-20', 70, 42, 'B7', 'l1f21bscs1066'),('2023-05-20', 70, 70, 'B8', 'l1f21bscs1067'),('2023-05-20', 70, 42, 'D6', 'l1f21bscs1068'),('2023-05-20', 70, 70, 'D14', 'l1f21bscs1069'),
    ('2023-05-20', 70, 42, 'D36', 'l1f21bscs1070'),('2023-05-20', 70, 70, 'D16', 'l1f21bscs1071'),('2023-05-20', 70, 42, 'D2', 'l1f21bscs1072'),('2023-05-20', 70, 70, 'D12', 'l1f21bscs1073'),    	('2023-05-20', 70, 48, 'C8', 'l1f21bscs1074'),('2023-05-20', 70, 42, 'C8', 'l1f21bscs1075'),('2023-05-20', 70, 48, 'C8', 'l1f21bscs1076'),('2023-05-20', 70, 42, 'C8', 'l1f21bscs1077'),
    ('2023-05-20', 70, 48, 'C8', 'l1f21bscs1078'),('2023-05-20', 70, 42, 'C8', 'l1f21bscs1079'),('2023-05-20', 70, 48, 'B11', 'l1f21bscs1080'),('2023-05-20', 70, 42, 'B12', 'l1f21bscs1081'),
    ('2023-05-20', 70, 48, 'B13', 'l1f21bscs1082'),('2023-05-20', 70, 42, 'A11', 'l1f21bscs1083'),('2023-05-20', 70, 48, 'A12', 'l1f21bscs1084'),('2023-05-20', 70, 42, 'A13', 'l1f21bscs1085'),
    ('2023-05-20', 70, 48, 'A14', 'l1f21bscs1086'),('2023-05-20', 70, 42, 'B6', 'l1f21bscs1087'),('2023-05-20', 70, 35, 'B7', 'l1f21bscs1088'),('2023-05-20', 70, 42, 'B8', 'l1f21bscs1089'),
    ('2023-05-20', 70, 35, 'D6', 'l1f21bscs1090'),('2023-05-20', 70, 42, 'D14', 'l1f21bscs1091'),('2023-05-20', 70, 35, 'D36', 'l1f21bscs1092'),('2023-05-20', 70, 42, 'D16', 'l1f21bscs1093'),
    ('2023-05-20', 70, 35, 'D2', 'l1f21bscs1094'),('2023-05-20', 70, 42, 'D12', 'l1f21bscs1095'),('2023-05-20', 70, 35, 'C8', 'l1f21bscs1096'),('2023-05-20', 70, 42, 'B13', 'l1f21bscs1097'),
    ('2023-05-20', 70, 35, 'B13', 'l1f21bscs1098'),('2023-05-20', 70, 42, 'B13', 'l1f21bscs1099'),('2023-05-20', 70, 35, 'B13', 'l1f21bscs1100'),('2023-05-20', 70, 42, 'B13', 'l1f21bscs1101'),
    ('2023-05-20', 70, 35, 'B11', 'l1f21bscs1102'),('2023-05-20', 70, 42, 'B12', 'l1f21bscs1103'),('2023-05-20', 70, 35, 'B13', 'l1f21bscs1104'),('2023-05-20', 70, 42, 'A11', 'l1f21bscs1105'),
    ('2023-05-20', 70, 65, 'A12', 'l1f21bscs1106'),('2023-05-20', 70, 42, 'A13', 'l1f21bscs1107'),('2023-05-20', 70, 65, 'A14', 'l1f21bscs1108'),('2023-05-20', 70, 42, 'B6', 'l1f21bscs1109'),
    ('2023-05-20', 70, 65, 'B7', 'l1f21bscs1110'),('2023-05-20', 70, 42, 'B8', 'l1f21bscs1111'),('2023-05-20', 70, 65, 'D6', 'l1f21bscs1112'),('2023-05-20', 70, 42, 'D14', 'l1f21bscs1113'),
    ('2023-05-20', 70, 65, 'D36', 'l1f21bscs1114'),('2023-05-20', 70, 42, 'D16', 'l1f21bscs1115'),('2023-05-20', 70, 65, 'D2', 'l1f21bscs1116'),('2023-05-20', 70, 42, 'D12', 'l1f21bscs1117'),
    ('2023-05-20', 70, 65, 'C8', 'l1f21bscs1118'),('2023-05-20', 70, 42, 'D36', 'l1f21bscs1119'),('2023-05-20', 70, 52, 'D36', 'l1f21bscs1120'),('2023-05-20', 70, 42, 'A11', 'l1f21bscs1121'),
    ('2023-05-20', 70, 52, 'A11', 'l1f21bscs1122'),('2023-05-20', 70, 42, 'B13', 'l1f21bscs1123'),('2023-05-20', 70, 52, 'B11', 'l1f21bscs1124'),('2023-05-20', 70, 42, 'B12', 'l1f21bscs1125'),
    ('2023-05-20', 70, 52, 'B13', 'l1f21bscs1126'),('2023-05-20', 70, 42, 'A11', 'l1f21bscs1127'),('2023-05-20', 70, 70, 'A12', 'l1f21bscs1128');
    
    
    ##########################
    ##########################
    ##########################
    ##########################
    ##########################
    
    