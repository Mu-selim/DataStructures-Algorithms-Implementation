/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let n = nums.length, temp = [];
    for(let i = 0; i < n; i++) {
        if(temp.includes(target-nums[i])) {
            return [i, nums.indexOf(target-nums[i])];
        } else {
            temp.push(nums[i]);
        }
    }
};

console.log(twoSum(nums = [2,7,11,15], target = 9));
console.log(twoSum(nums = [3,2,4], target = 6));
console.log(twoSum(nums = [3,3], target = 6));