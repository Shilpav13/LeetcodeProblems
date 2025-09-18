class Solution:
    def reverseString(self, s: List[str]) -> None:
        start= 0
        n= len(s)
        end= n-1
        temp = 0
        while start<end:
            
            temp=s[start] 
            s[start] = s[end]
            s[end] = temp
            start +=1 
            end -=1
            
       
        