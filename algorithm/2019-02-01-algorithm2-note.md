# [十道簡單的演算法](https://segmentfault.com/a/1190000014231566)
# PHP 版
## 2. 找出最常用的數字(長度為 n 的陣列，有個數字出現的次數大於 n / 2 ，找出這個數字)
```
function mostCommonlyUsedTheNumber($numbers)
{
    $front = -1;

    foreach ($numbers as $key => $value) {
        if (($front === -1) || ($stack[$front] === $value)) {
            $stack[++$front] = $value;
        } else {
            --$front;
        }
    }
    return $stack[0];
}

var_dump(mostCommonlyUsedTheNumber([1, 5, 2, 2, 2, 3, 4]));
```
## 3. 丟失的數字(一組[0, 1, 2, 3, ... , n]的連號陣列，缺少了一個數字，找出這個數字)
```
/**
 *
 * @param array $numbers
 * @return int
 * @link https://zh.wikipedia.org/zh-tw/%E7%AD%89%E5%B7%AE%E6%95%B0%E5%88%97
 */
function missingNumber($numbers)
{
    // 等差級數公式
    $total = round((($numbers[0] + end($numbers)) * (count($numbers) + 1)) / 2);
    return $total - array_sum($numbers);
}

echo missingNumber([0, 2, 4, 8, 10, 12, 14, 16, 18]);
```
## 4. 將 0 放在最後(將陣列中的0移至最後)
```
function moveZero($numbers)
{
    $zeroIndex = count($numbers);

    for ($i = $zeroIndex - 1; $i > -1; --$i) {
        if ($numbers[$i] === 0 && $i !== $zeroIndex) {
            $tmp = $numbers[--$zeroIndex];
            $numbers[$zeroIndex] = 0;
            $numbers[$i] = $tmp;
        }
    }
    return $numbers;
}

print_r(moveZero([3, 2, 4, 6, 0, 5, 0, 7]));
```
## 5. 找出陣列中只出現一次的數字
```
/**
 * 用 XOR 的方式
 *
 */
function other()
{
    $nums = [1, 2, 3, 4, 4, 5, 5, 5, 6, 6];
    $k = $nums[0];
    $numSize = count($nums);
    for ($i = 1; $i < $numSize; $i++) {
        $k = ($k ^ $nums[$i]);
    }
    print_r($k);
}

function singleNumber($numbers)
{
    foreach ($numbers as $value) {
        if (! isset($more[$value]) && isset($one[$value])) {
            unset($one[$value]);
            $more[$value] = 1;
        } else if (! isset($more[$value]) && ! isset($one[$value])) {
            $one[$value] = 1;
        }
    }
    return array_keys($one);
}
print_r(singleNumber([1, 2, 3, 4, 4, 5, 5, 5, 6, 6]));
```
## 6. 畫三角形
```
function drawStar()
{
    for ($i = 1; $i <= 4; $i++) {
        $star = implode('', array_fill(0, ($i * 2) - 1, '*'));
        $line = str_pad($star, 7, ' ', STR_PAD_BOTH);
        echo $line . PHP_EOL;
    }
}
drawStar();
```
# C# 版