# [十道簡單的演算法](https://segmentfault.com/a/1190000014082596)
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
// 方法 1
function monkeyQue($day) {
    if($day === 1) {
        // echo "day 1 : 1" . PHP_EOL;
        return 1;
    } else {
        $count = 2 * monkeyQue($day - 1) + 2;
        echo "day {$day} : {$count}" . PHP_EOL;
        return $count;
    }
}
echo monkeyQue(10);

// 方法 2
function monkeyQue($day) {
    $peach = 1;
    for($i = 0 ; $i < $day ; $i++) {
        $a= ($peach + 1) * 2;
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

```