/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function(nums, target) {
    let l = 0, r = nums.length, mid;
    while(l < r) {
        mid = l + Math.floor(((r-l) / 2));
        if(nums[mid] === target)
            return mid;
        else if(nums[mid] > target)
            r = mid;
        else
            l = mid+1;
    }
    return l;
};

console.log(searchInsert(nums = [1,3,5,6], target = 5));
console.log(searchInsert(nums = [1,3,5,6], target = 2));
console.log(searchInsert(nums = [1,3,5,6], target = 7));
console.log(searchInsert(nums = [1,3], target = 0));
console.log(searchInsert(nums = [1,3], target = 2));