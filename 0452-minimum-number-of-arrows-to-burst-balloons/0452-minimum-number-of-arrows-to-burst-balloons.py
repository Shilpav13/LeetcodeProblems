class Solution:
    def findMinArrowShots(self, points: List[List[int]]) -> int:
        points.sort(key=lambda x: x[0])

        arrow = 1
        end = points[0][1]

        for baloon in points[1:]:
            if baloon[0] > end:
                arrow = arrow + 1
                end = baloon[1]
            else:
                end = min(end, baloon[1])
        return arrow
