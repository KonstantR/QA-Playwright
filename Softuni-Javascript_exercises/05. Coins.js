function coins(input) {
    let change = Number(input);             
    let stotinki = Math.round(change * 100);

    let coinsCount = 0;
    const coins = [200, 100, 50, 20, 10, 5, 2, 1];

    for (let coin of coins) {
        coinsCount += Math.floor(stotinki / coin);
        stotinki %= coin;
    }

    console.log(coinsCount);
}
coins(["1.23"]); 
coins(["2"]);    
coins(["0.56"]);
coins(["2.73"]);