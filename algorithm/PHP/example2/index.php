<?php

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

// var_dump(mostCommonlyUsedTheNumber([1, 5, 2, 2, 2, 3, 4]));

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

// echo missingNumber([0, 2, 4, 8, 10, 12, 14, 16, 18]);

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

// print_r(moveZero([3, 2, 4, 6, 0, 5, 0, 7]));

function singleNumber($numbers)
{
    foreach ($numbers as $value) {
        if (isset($tmp[$value])) {
            unset($tmp[$value]);
        } else {
            $tmp[$value] = 1;
        }
    }
    return array_keys($tmp);
}
print_r(singleNumber([1, 2, 3, 4, 4, 5, 5, 5, 6, 6]));
