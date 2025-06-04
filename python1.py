#Exercise 1

n = 7
if n % 2 == 0:
    print("n is even")
else:
    print("n is odd")

#Exercise 2

age = int(input("How old are you? "))

if age < 18:
    print("Minor")
elif age < 65:
    print("Adult")
else:
    print("Senior")

#Exercise 3

temperatures = [72, 85, 90, 65, 70]
for temperature in temperatures:
    print(temperature, end='')
    if temperature >= 85:
        print(": Hot")
    elif temperature >= 70:
        print(": Warm")
    else:
        print(": Cool")

#Exercise 4

sales = [("Ana", 3500), ("Ben", 1800), ("Chloe", 2500)]

for salesperson, sale in sales:
    print(salesperson, end="")
    if sale > 3000:
        print(": Top bonus")
    elif sale > 2000:
        print(": Standard Bonus")
    else:
        print(": No bonus")

#Exercise 5

players = [
    {"name": "Maya", "score": 950},
    {"name": "Liam", "score": 1150},
    {"name": "Zoe", "score": 780}
]

def assign_rank(score):
    if score > 1000:
        return "Gold"
    elif score > 800:
        return "Silver"
    else:
        return "Bronze"

for player in players:
    #print(player)
    player["rank"] = assign_rank(player["score"])
    print(player["name"], end=" , ")
    print(player["score"], end=" , ")
    print(player["rank"])

#Extra

lives = 3
while lives > 0:
    lives -= 1
    if lives == 0:
        print("No more lives")
    else:
        print("Still alive!")

weekly_scores = [
    [850, 900, 870, 910, 890, 920, 880],  # Week 1
    [930, 940, 950, 920, 910, 960, 970]   # Week 2
]

print("Weekly scores are:")
for week in weekly_scores:
    weekly_sum = 0
    for score in week:
        weekly_sum += score
    print(weekly_sum)

while True:
    try:
        try_practice = int(input("Enter a number: "))
        break
    except ValueError:
        print("Invalid input! Input is not a number. Try again...")


city = "New York"
days = 3
cost = 123.45
go_back = True

total_cost = days * cost
print(f"Total cost: {total_cost}")
cost_per_hour = cost / 10
print(f"Cost per hour: {cost_per_hour}")

num_books = int(input("How many books did you read last year? "))
avg_pages = int(input("On average, how many pages where in each book? "))

total_pages = num_books * avg_pages
print(f"Total pages read last year: {total_pages}")

temp = int(input("What is the temperature: "))

if temp > 85:
    print("Hot")
elif temp >= 60:
    print("Warm")
elif temp >= 32:
    print("Cold")
else:
    print("Freezing")