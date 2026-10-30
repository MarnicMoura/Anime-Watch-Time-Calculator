#anime thing

Episode_Number_Total = 0
Total_Time = 0
Sequel_Episode_List = []
Sequel_Time_List = []

Anime_Name = input("What is the name of the anime? ")
Episode_Number = int(input("How many episodes are there? "))
Episode_Duration = float(input("How long is the average episode in minutes? "))
Time = float((Episode_Number*Episode_Duration)/60)

Sequel_Yes = input ("Are there any sequels or spinoffs you want to include? (Y)es or (N)o ")
if Sequel_Yes.lower() == 'y':
  Sequel_Number = int(input("How many sequels or spinoffs are there? "))
  while Sequel_Number > 0:
    Sequel_Episode_Number = int(input("How many episodes are there? "))
    Sequel_Episode_List.append(Sequel_Episode_Number)
    
    Sequel_Episode_Duration = float(input("How long is the average episode in minutes? "))
    Sequel_Time = float((Sequel_Episode_Number*Sequel_Episode_Duration)/60)
    Sequel_Time_List.append(Sequel_Time)
    Sequel_Number = Sequel_Number - 1
    
    Episode_Number_Total = sum(Sequel_Episode_List, Episode_Number)
    Total_Time = sum(Sequel_Time_List, Time)
  print ("There are a total of",Episode_Number_Total, "episodes")
  print ("This anime, including all it's sequels and spinoffs, will take",Total_Time, "hours to complete")

elif Sequel_Yes.lower() == 'n':
  print ("This anime will take", Time, "hours to complete")

  
sourceFile = open('anime.txt', 'w')
print(Anime_Name, file = sourceFile)
if Sequel_Yes.lower() == 'y':
  print("Including sequels or spinoffs, there are", Episode_Number_Total,"episodes for this anime.", file = sourceFile)
  print("This anime, including all it's sequels and spinoffs, will take", Total_Time, "hours to complete", file = sourceFile)
  
elif Sequel_Yes.lower() == 'n':
  print("This anime has", Episode_Number, "episodes.", file = sourceFile)
  print("This anime will take", Time, "hours to complete.", file = sourceFile)

print(" ", file = sourceFile)
sourceFile.close()