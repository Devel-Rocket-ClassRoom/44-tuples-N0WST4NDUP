using System;

var s1 = CreateStudent("철수", 16, 1);
var s2 = CreateStudent("영희", 17, 2);
var s3 = CreateStudent("민수", 18, 3);

Console.WriteLine("=== 학생 정보 출력 ===");
PrintStudent(s1);
PrintStudent(s2);
PrintStudent(s3);

var (name, age, grade) = s1;
Console.WriteLine(@$"
=== 첫 번째 학생 분해 ===
이름: {name}
나이: {age}
학년: {grade}");

(string name, int age, int grade) CreateStudent(string name, int age, int grade) => (name, age, grade);

void PrintStudent((string name, int age, int grade) t) => Console.WriteLine($"{t.name} - 나이: {t.age}세, 학년: {t.grade}학년");