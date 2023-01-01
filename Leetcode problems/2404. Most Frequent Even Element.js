/**
 * @param {number[]} nums
 * @return {number}
 */
var mostFrequentEven = function(nums) {
    let freq = new Map(), mostFreq = -1, max = 0;
    for(let num of nums) {
        if(num & 1) 
            continue;
        freq.set(num, (freq.get(num) || 0) + 1);
        let count = freq.get(num);
        if(count > max) {
            max = count;
            mostFreq = num;
        } else if(count === max && num < mostFreq) {
            mostFreq = num;
        }
    }
    return mostFreq;
};

console.log(mostFrequentEven(nums = [0,1,2,2,4,4,1])); // 2
console.log(mostFrequentEven(nums = [4,4,4,9,2,4])); // 4
console.log(mostFrequentEven(nums = [29,47,21,41,13,37,25,7])); // -1
console.log(mostFrequentEven([0, 0, 0, 0])); // 0
console.log(mostFrequentEven([2,10000,10000,10000,2])); // 10000
