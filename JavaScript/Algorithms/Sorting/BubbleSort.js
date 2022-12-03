const bubbleSort = (array) => {
    const len = array.length;
    for(let i = 0; i < len-1; i++) {
        for(let j = 0; j < len-i-1; j++) {
            if(array[j] > array[j+1])
                [array[j], array[j+1]] = [array[j+1], array[j]]; // swap
        }
    }

    return array;
}


const optimizedBubbleSort = (array) => {
    const len = array.length;
    for(let i = 0; i < len-1; i++) {
        let swapHappend = false;
        for(let j = 0; j < len-i-1; j++) {
            if(array[j] > array[j+1]) {
                [array[j], array[j+1]] = [array[j+1], array[j]]; // swap
                swapHappend = true;
            }
        }

        if(!swapHappend)
            break;
    }

    return array;
}

console.log(bubbleSort([1, -4, 12, 20, -3, -7, 12, 1]));
console.log(optimizedBubbleSort([1, -4, 12, 20, -3, -7, 12, 1]));