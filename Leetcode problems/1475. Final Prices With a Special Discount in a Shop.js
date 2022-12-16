/**
 * @param {number[]} prices
 * @return {number[]}
 */
var finalPrices = function(prices) {
    let priceLength = prices.length, answer = [];
    for(let i = 0; i < priceLength; i++) {
        answer.push(prices[i]);
        for(let j = i+1; j < priceLength; j++) {
            if(prices[i] >= prices[j]) {
                answer[i] = prices[i]-prices[j];
                flag = true;
                break;
            }
        }
    }
    return answer;
};

console.log(finalPrices(prices = [8,4,6,2,3]));
console.log(finalPrices(prices = [1,2,3,4,5]));
console.log(finalPrices(prices = [10,1,1,6]));