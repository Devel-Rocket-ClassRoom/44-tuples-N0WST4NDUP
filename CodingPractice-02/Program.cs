using System;

// 1. 기본 튜플 반환
// var t = Tally();
// Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");

// // 튜플 반환 메서드
// static (int, int) Tally()
// {
//     var result = (12, 3);
//     return result;
// }

// 2. 반환 튜플에 이름 지정
// var result = Calculate();
// Console.WriteLine($"합계: {result.Sum}, 개수: {result.Count}");

// // 반환 튜플에 이름 지정
// static (int Sum, int Count) Calculate()
// {
//     return (45, 6);
// }

// 3. 표현식 본문으로 간결하게 작성
// var pair = GetPair();
// Console.WriteLine($"{pair.first}, {pair.second}");

// // 표현식 본문으로 간결하게
// static (int first, int second) GetPair() => (100, 200);

// 4. 최솟값과 최댓값 반환
// int[] data = { 5, 2, 8, 1, 9, 3 };
// var result = FindMinMax(data);
// Console.WriteLine($"최솟값: {result.min}, 최댓값: {result.max}");

// static (int min, int max) FindMinMax(int[] numbers)
// {
//     int min = numbers[0];
//     int max = numbers[0];

//     foreach (int num in numbers)
//     {
//         if (num < min)
//         {
//             min = num;
//         }
//         if (num > max)
//         {
//             max = num;
//         }
//     }

//     return (min, max);
// }

// 5. 기본값 반환
// var zeros = ZeroZero();
// Console.WriteLine($"{zeros.Item1}, {zeros.Item2}");  // 0, 0

// static (int, int) ZeroZero() => default;

// 6. 분해 기본
// var bob = ("Bob", 23);

// // 튜플 분해
// (string name, int age) = bob;

// Console.WriteLine($"이름: {name}");
// Console.WriteLine($"나이: {age}");

// 7. var를 사용한 분해
// var (sum, count) = Tally();
// Console.WriteLine($"Sum: {sum}, Count: {count}");

// static (int Sum, int Count) Tally() => (12, 3);

// 8. 기존 변수에 분해
// string firstName = "";
// int userAge = 0;

// var person = ("Alice", 30);

// // 기존 변수에 분해
// (firstName, userAge) = person;

// Console.WriteLine($"{firstName}, {userAge}");

// 9. 무시 패턴 (`_`)
var (_, age, _) = GetPerson();
Console.WriteLine($"나이: {age}");

static (string name, int age, char gender) GetPerson() => ("Bob", 23, 'M');