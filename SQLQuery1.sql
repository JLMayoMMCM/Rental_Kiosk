CREATE TABLE [dbo].[studentData] (
    [PrimaryKey] INT          NOT NULL,
    [StudentID]  CHAR (10)    NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Program]    VARCHAR (52) NOT NULL,
    [ContactNo]  CHAR (13)    NOT NULL,
    [IsEnrolled] BIT          NOT NULL,
    CONSTRAINT [PK_studentData] PRIMARY KEY CLUSTERED ([PrimaryKey] ASC)
);

INSERT INTO [dbo].[studentData] ([PrimaryKey], [StudentID], [name], [Program], [ContactNo], [IsEnrolled]) 
VALUES
(1, '2023130039', 'Anne Klein Amoroso', 'Bachelor of Science in Information Systems', '+639456540145', 1),
(2, '2023130392', 'Ansharlene Crystal Balagosa', 'Bachelor of Science in Information Systems', '+639361105331', 1),
(3, '2021141125', 'Ineke Vrede Lumaad', 'Bachelor of Science in Information System', '+639218665739', 1),
(4, '2023130275', 'John Rhynier Risaba', 'Bachelor of Science in Information System', '+639703452627', 1),
(5, '2023130383', 'Mayrell Olarte', 'Bachelor of Science in Information Systems', '+639484523451', 1),
(6, '2023130630', 'Nepthali II C. Sollano', 'Bachelor of Science in Information Systems', '+639096002006', 1),
(7, '2023130104', 'Joshua Sabuero', 'Bachelor of Science in Information Systems', '+639626917893', 1),
(8, '2023130369', 'Nhowa Argallon', 'Bachelor of Science in Information Systems', '+639276160122', 1),
(9, '2023130368', 'Sandara Monterola', 'Bachelor of Science in Information System', '+639451542813', 1),
(10, '2021110166', 'Jonathan Lance Mayo', 'Bachelor of Science in Information Systems', '+639205696575', 1);

