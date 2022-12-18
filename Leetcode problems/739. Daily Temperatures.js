/**
 * @param {number[]} temperatures
 * @return {number[]}
 */
var dailyTemperatures = function(temperatures) {
    let len = temperatures.length;
    let res = new Array(len).fill(0), stack = [];
    for(let i = 0; i < len; i++) {
        while(stack.length > 0 && temperatures[i] > temperatures[stack[stack.length-1]]) {
            let index = stack.pop();
            res[index] = i - index;
        }
        stack.push(i);
    }
    return res;
};

console.log(dailyTemperatures(temperatures = [73,74,75,71,69,72,76,73]));
console.log(dailyTemperatures(temperatures = [30,40,50,60]));
console.log(dailyTemperatures(temperatures = [30,60,90]));