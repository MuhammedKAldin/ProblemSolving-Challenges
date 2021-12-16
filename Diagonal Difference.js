function diagonalDifference(arr) {
    // Write your code here
    let sum_1 = 0;
    let sum_2 = 0;
    for(var i =0; i<arr.length; i++)
    {
       // [0][0] , ,1][1] , [2][2] etc
       sum_1 += arr[i][i];
       sum_2 += arr[arr.length - 1 - i][i];
    }
    
    return Math.abs(sum_1-sum_2);
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    let arr = Array(n);

    for (let i = 0; i < n; i++) {
        arr[i] = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));
    }

    const result = diagonalDifference(arr);

    ws.write(result + '\n');

    ws.end();
}
