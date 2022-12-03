const selectionSort = (array) => {
    const len = array.length;
    for(let i = 0; i < len; i++) {
        let minIndex = i;
        for(let j = i+1; j < len; j++) {
            if(array[minIndex] > array[j]) {
                minIndex = j;
            }
        }
        [array[minIndex], array[i]] = [array[i], array[minIndex]];
    }

    return array;
}

console.log(selectionSort([1, 5, 4, 7, -1, 1, 0, -5, 9, 6]));