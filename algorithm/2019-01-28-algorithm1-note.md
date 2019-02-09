# [十道簡單的演算法](https://segmentfault.com/a/1190000014082596)
# PHP 版
## 1. `1-n` 階乘
``` 
function factorial($input) {
    $tmp = $input - 1;
    if($tmp === 1) {
        return $input ;
    } else {
        return factorial($tmp) * $input;
    }
}
```
## 2. 二維陣列每列最小值
```
// 方法 1
foreach($twoArray as $value) {
    $min[] = min($value);
}
// 方法 2
foreach($twoArray as $key => $value) {
    $tmp[$key] = PHP_INT_MAX;
    foreach($value as $num) {
        if($num < $tmp[$key]) {
            $tmp[$key] = $num;
        }
    }
}
```
## 3. 求"1！+4！(2的平方)+9！(3的平方)+...+n的值
`看嘸…`
## 4. 陣列對角線值之和
```
$extraCount = count($twoArray);
$sum = 0;
for($i = 0 ; $i < $extraCount ; $i++) {
    $count = count($twoArray[$i]);
    $last = $count - $i - 1;
    $sum += $twoArray[$i][$i];// + $twoArray[$i][$last];
}
echo $sum
```
## 5. 列出楊輝三角形
[三角形長相](https://image-static.segmentfault.com/400/039/4000391670-5abd9ed5c6fbd)
`不知怎麼弄…`
## 6. 猴子吃桃子問題
```
function monkeyQue($day) {
    $peach = 1;
    for($i = 0 ; $i < $day ; $i++) {
        $peach= ($peach + 1) * 2;
    }
    return $peach;
}
echo monkeyQue(10);
```
## 7. 計算單字的個數
```
function countWord($str) {
    return explode(' ', $str);
}
echo counWord('This is a Apple');
```
## 8. 判斷字母是否完全一樣(不管順序)
```
function stringCompare($str1, $str2) {
    $str1Value = alphaCompare($str1);
    $str2Value = alphaCompare($str2);
    print_r($str1Value);
    print_r($str2Value);
    return array_sum($str1Value) === array_sum($str2Value);
}
function alphaCompare($str) {
    $length = strlen($str);
    for($i = 0 ; $i < $length ; $i++) {
        $tmp[] = ord($str[$i]) - ord('a');
    }
    return $tmp ?? [];
}

var_dump(stringCompare('Hello World', 'World Hello'));
```
## 9. 判斷某個數字是否為 2 的倍數
```
function checkEven($numeric) {
    if ($numeric === 1 || $numeric === 0) {
        return false;
    }
    return ($numeric ^ ($numeric + 1)) === 1;
}
```
## 10. 判斷數字是否為 ugly number (分解出來的質因數只有 2, 3, 5 這三個數字）
```
function isUgly($numeric) {
    if($numeric <= 1) {
        return false;
    }

    while ($numeric % 2 == 0) {
        $numeric = $numeric / 2;
    }
    while ($numeric % 3 == 0) {
        $numeric = $numeric / 3;
    }
    while ($numeric % 5 == 0) {
        $numeric = $numeric / 5;
    }

    return $numeric === 1;
}
```

---

# C# 版
## 1. `1-n` 階乘
```
int factorial(int numeric)
{
    int tmp = numeric - 1;

    if (tmp == 1)
    {
        return numeric;
    }
    else
    {
        return this.factorial(tmp) * numeric;
    }
}
```
## 2. 二維陣列每列最小值
```
using System.Collections.Generic;
using System.Linq;

static void Main(string[] args)
{
    var method2 = new Program();
    List<int[]> twoArray = new List<int[]> {
            new int[] {1, 23, 43, 97, 345},
            new int[] {190, 123, 3, 917, 345},
            new int[] {981, 243, 3, 97, 345},
            new int[] {121, 283, 4903, 15, 345},
            new int[] {2331, 2, 42, 354, 67545},
        };
    method2.minArray(twoArray);
}

void minArray(List<int[]> twoArray)
{
    foreach (var item in twoArray)
    {
        Console.WriteLine(item.Min());
    }
}
```
## 3. 求"1！+4！(2的平方)+9！(3的平方)+...+n的值
## 4. 陣列對角線值之和
```
void diagonal(List<int[]> twoArray)
{
    int sum = 0;
    for (int i = 0; i < twoArray.Count; i++)
    {
        sum += twoArray[i][i];
    }
    Console.WriteLine($"sum:{sum}");
}
```
## 5. 列出楊輝三角形
## 6. 猴子吃桃子問題
```
void monkeyQue(int day)
{
    int peach = 1;
    for (int i = 0; i < day; i++)
    {
        peach = (peach + 1) * 2;
    }
    Console.WriteLine($"peach:{peach}");
}
```
## 7. 計算單字的個數
```
void countWord(string str)
{
    Console.WriteLine($"Word count:{str.Split(" ").Count()}");
}
```
## 8. 判斷字母是否完全一樣(不管順序)
```
void stringCompare(string str1, string str2)
{
    Console.WriteLine(this.characterCalculator(str1) == this.characterCalculator(str2));
}

private int characterCalculator(string str)
{
    byte[] result = Encoding.ASCII.GetBytes(str);
    return result.Sum(i => i);
}
```
## 9. 判斷某個數字是否為 2 的倍數
```
void isEven(int numeric)
{
    Console.WriteLine($"{(numeric % 2) == 0}");
}
```
## 10. 判斷數字是否為 ugly number (分解出來的質因數只有 2, 3, 5 這三個數字）
```
void isUglyNumber(int numeric)
{
    bool result = false;
    int tmp = numeric;
    if(tmp > 0) {
        while (tmp % 2 == 0) {
            tmp = tmp / 2;
        }
        while (tmp % 3 == 0) {
            tmp = tmp / 3;
        }
        while (tmp % 5 == 0) {
            tmp = tmp / 5;
        }
    }
    result = tmp == 1;
    Console.WriteLine($"Numeric {numeric} {(result ?"": "not")} is ugly number");
}
```