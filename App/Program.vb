Imports StudentLibrary
Imports TeachersLibrary
Module Program
    Sub Main()
        ' Use the Student class from StudentLibrary
        Dim student As New Student With {.Name = "John Doe", .Age = 20}

        ' Use the Teacher class from TeachersLibrary
        Dim teacher As New Teacher With {.Name = "Mrs. Smith", .Subject = "Math"}

        Console.WriteLine($"Student: {student.Name}, Age: {student.Age}")
        Console.WriteLine($"Teacher: {teacher.Name}, Subject: {teacher.Subject}")
    End Sub
End Module