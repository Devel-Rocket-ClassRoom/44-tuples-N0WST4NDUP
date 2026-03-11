using System;
using System.Collections.Generic;

List<(string name, int quantity, int price)> inventory = new();
AddItem(inventory, "체력 포션", 3, 500);
AddItem(inventory, "마나 포션", 5, 800);
AddItem(inventory, "해독제", 2, 300);
AddItem(inventory, "엘릭서", 1, 5000);

Console.WriteLine("=== 아이템 인벤토리 ===");
inventory.ForEach((e) => Console.WriteLine($"{e.name} - 수량: {e.quantity}개, 단가: {e.price}원"));
Console.WriteLine();

var max = FindMostExpensive(inventory);
Console.WriteLine("=== 가장 비싼 아이템 ===");
Console.WriteLine($"이름: {max.name}, 단가: {max.price}원");

var total = CalculateTotal(inventory);
Console.WriteLine("=== 인벤토리 합산 ===");
Console.WriteLine($"총 가치: {total.totalValue:0,000}원");
Console.WriteLine($"총 아이템 수: {total.totalCount}개");

void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price) => inventory.Add((name, quantity, price));

(string name, int price) FindMostExpensive(List<(string name, int quantity, int price)> inventory)
{
    (string name, int price) expensive = default;
    inventory.ForEach((t) =>
    {
        if (t.price > expensive.price) expensive = (t.name, t.price);
    });
    return expensive;
}

(int totalValue, int totalCount) CalculateTotal(List<(string name, int quantity, int price)> inventory)
{
    (int totalValue, int totalCount) totals = default;
    inventory.ForEach((t) =>
    {
        totals.totalValue += t.price * t.quantity;
        totals.totalCount += t.quantity;
    });
    return totals;
}
