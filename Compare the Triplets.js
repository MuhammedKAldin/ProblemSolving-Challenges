function compareTriplets(a, b) {
    let Alice = 0;
    let Bob = 0;
    // Execluding the x[3] & +Length from the comaprision
    for(var i = 0; i <= a.length - 1; i++)
    {
        if(a[i] > b[i])
        {
            Alice ++; 
        } else if(a[i] < b[i]) {
            Bob ++; 
        }
    }
    return [Alice, Bob];
 }

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const a = readLine().replace(/\s+$/g, '').split(' ').map(aTemp => parseInt(aTemp, 10));

    const b = readLine().replace(/\s+$/g, '').split(' ').map(bTemp => parseInt(bTemp, 10));

    const result = compareTriplets(a, b);

    ws.write(result.join(' ') + '\n');

    ws.end();
}
