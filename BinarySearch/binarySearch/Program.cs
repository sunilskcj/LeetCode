Search([-1,0,3,5,9,12], 9);

 int Search(int[] nums, int target) {
        if(nums.Length < 0) return -1;
        int start=0, end=nums.Length-1;
        while(start <= end){
            int mid=start+(end-start)/2;
            if(nums[mid] < target) {start = mid +1;}
            else if(nums[mid] > target) {end = mid-1;}
            else{return mid;}            
        }
        return -1;
    }