<?php
class Solution {
    function twoSum(array $nums, $target) {
        /** 用 array_flip 會有相同值轉換時被去重複的問題
         * 例如： [3, 3]
         * array_flip 之後會變成 [0:3] 剩一組
         */
        // $tmp = array_flip($nums);
        // foreach ($tmp as $key => $value) {
        //     $complement = $target - $key;
        //     if(isset($tmp[$complement]) && $key !== $complement) {
        //         return [$tmp[$key], $tmp[$complement]];
        //     }
        // }
        /**
         * 不用 array_flip 直接比對是否有值
         */
        foreach ($nums as $key => $value) {
            $complement = $target - $value;
            if(isset($tmp[$complement])) {
                return [$key, $tmp[$complement]];
            } else {
                $tmp[$value] = $key;
            }
        }
    }
}

$a = new Solution;
// print_r($a->twoSum([3, 3], 6));
print_r($a->twoSum([3, 2, 8, 4], 6));