namespace Tasks;
public class TaskBestTimeToBuyAndSellStock {
    public int MaxProfit(int[] prices) {
       int prof = 0;
       int low = prices[0];
       for(int i = 0; i < prices.Length; ++i){

           if(prices[i] < low)
               low = prices[i];

            if(prices[i] - low > prof)
                prof = prices[i] - low;
       } 
       return prof;
    }
}