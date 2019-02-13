<?php
class Solution {
    function twoSum(array $nums, $target) {
        foreach ($nums as $key => $value) {
            $complement = $target - $value;
            if(isset($tmp[$complement])) {
                $index1 = $key + 1;
                $index2 = $tmp[$complement] + 1;
                return $index1 > $index2 ? [$index2, $index1] : [$index1, $index2];
            } else {
                $tmp[$value] = $key;
            }
        }
    }
}

$a = new Solution;
// print_r($a->twoSum([3, 3], 6));
print_r($a->twoSum([3, 2, 8, 4], 6));