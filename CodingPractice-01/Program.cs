using System;

// 1. 튜플 리터럴
// var bob = ("Bob", 23);

// Console.WriteLine(bob.Item1); // Bob
// Console.WriteLine(bob.Item2); // 23

// 2-1. 같은 타입의 튜플
// var numbers = (12, 34, 56);
// Console.WriteLine($"{numbers.Item1}, {numbers.Item2}, {numbers.Item3}");

// 2-2. 서로 다른 타입의 튜플
// var mixed = ("Hello", 100, true, 3.14);
// Console.WriteLine($"{mixed.Item1}, {mixed.Item2}, {mixed.Item3}, {mixed.Item4}");

// // 3-1. 기본 명시적 타입
// (string, int) person = ("Alice", 25);
// Console.WriteLine($"{person.Item1}, {person.Item2}");

// // 3-2. 이름이 있는 명시적 타입
// (ushort Width, ushort Height) resolution = (1920, 1080);
// Console.WriteLine($"해상도: {resolution.Width} x {resolution.Height}");

// 4. 튜플의 값 타입 특성
// var original = ("Bob", 23);
// var copy = original;  // 복사본 생성

// copy.Item1 = "Joe";   // 복사본만 변경됨

// Console.WriteLine($"원본: {original}");  // (Bob, 23)
// Console.WriteLine($"복사본: {copy}");    // (Joe, 23)

// 5. 생성 시 이름 지정
// var person = (name: "Bob", age: 23);
// Console.WriteLine(person.name);  // Bob
// Console.WriteLine(person.age);   // 23

// Console.WriteLine(person.Item1); // Bob
// Console.WriteLine(person.Item2); // 23

// 6. 요소 이름 지정 예제
// var student = (Name: "철수", IsStudent: true, OrderPrice: 1_000);
// Console.WriteLine($"{student.Name}(학생: {student.IsStudent}) - 주문: {student.OrderPrice:N0}원");

// 7. 타입 선언에서 이름 지정
// 타입 선언에서 이름 지정
// (string name, int age, char gender) person = ("Bob", 23, 'M');
// Console.WriteLine($"이름: {person.name}");
// Console.WriteLine($"나이: {person.age}");
// Console.WriteLine($"성별: {person.gender}");

// 8. 요소 이름 자동 추론
var now = DateTime.Now;
var dateTuple = (now.Day, now.Month, now.Year);

Console.WriteLine($"일: {dateTuple.Day}");
Console.WriteLine($"월: {dateTuple.Month}");
Console.WriteLine($"년: {dateTuple.Year}");