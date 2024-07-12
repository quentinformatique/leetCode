class Solution:
    def addDigits(self, num: int) -> int:
        numstr = str(num)
        if len(numstr) == 1:
            return num
        else:
            somme = 0
            for i in numstr:
                somme += int(i)
            return self.addDigits(somme)