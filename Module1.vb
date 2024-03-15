Imports System
Imports System.Reflection.Metadata
'Name: Ishraq Alam
'Date: June 16, 2023
'Title: Culminating_UnravelIA
'Purpose: The purpose of the game is to escape the building by using available clues and making decisions that will lead to an exit. Just before the user reaches the exit, they will have to face a monster, and once they win against the monster, they will successfully beat the game.

Module Program
    Dim strUser As String 'User input (yogurt container), it is used to get user responses. 
    Sub Main(args As String())
        Console.WriteLine(" _.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-. UNRAVEL .-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._") 'This is the title of the game - Unravel
        Console.WriteLine("")
        Console.WriteLine("Welcome to Unravel...") 'This is an introduction to the game and gives the user context to the story
        Console.WriteLine("Darkness wraps around you like a blanket that never ends. The room you're in is quiet and you feel strange and confused. Thoughts swirl your mind, but you can't pinpoint what they are or where they come from.")
        Console.WriteLine("")
        Console.WriteLine("Suddenly, a bright red-orange flame bursts on a candle that appeared from within the void. With curiosity, you approach it and to your surprise, a note is attached to it.")
        Console.WriteLine("")
        Console.WriteLine("'You must escape at all costs! WIN FOR ALL OF US...'")
        Console.WriteLine("")
        Console.WriteLine("0================================================0") 'ASCII art of a room to help player visualize
        Console.WriteLine("|'.                    (|)                     .'|")
        Console.WriteLine("|  '.                   |                    .'  |")
        Console.WriteLine("|    '.                |O|                 .'    |")
        Console.WriteLine("|      '. ____________/===\_____________ .'      |")
        Console.WriteLine("|        :            `\'/`  ______     :     .. |")
        Console.WriteLine("|        :     mmmmmmm  V   |--%%--|    :   .'|| |")
        Console.WriteLine("|        :     |  |  |      |-%%%%-|    :  |  || |")
        Console.WriteLine("|        :     |--|--| @@@  |=_||_=|    :  I  || |")
        Console.WriteLine("|        :     |__|__|@@@@@ |_\__/_|    :  |  || |")
        Console.WriteLine("|        :             \|/   ____       :  |  || |")
        Console.WriteLine("|        :;;       .'``(_)```\__/````:  :  |  || |")
        Console.WriteLine("|        :||___   :================:'|  :  | 0+| |")
        Console.WriteLine("|        :||===)  | |              | |  :  |  || |")
        Console.WriteLine("|        ://``\\__|_|______________|_|__:  I  || |")
        Console.WriteLine("|      .'/'    \' | '              | '   '.|  || |")
        Console.WriteLine("|    .'           |                |       '. || |")
        Console.WriteLine("|  .'                                        '|| |")
        Console.WriteLine("|.'                                            '.|")
        Console.WriteLine("0================================================0")
        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        Console.WriteLine(".--..--..--.ABOUT.--..--..--.") 'This is the about section for the programmer
        Console.WriteLine("Unravel is a text-based, decision-based, and role-playing adventure game. The name Unravel stems from the objective of the game, which is to unravel various clues and solve challenges in order to proceed and eventually escape the game. It is recommended for people of all ages and remains exciting for everyone!")
        Console.WriteLine("Programmer: Ishraq Alam")
        Console.WriteLine("Date Published: June 16, 2023")
        Console.WriteLine("Class Code: TEJ2O1")
        TypeToContinue()
        Dim intMainMenuResponse As Integer 'User's response to menu items
        Do
            Menu() 'Inserts a method called Menu
            strUser = Console.ReadLine()
            intMainMenuResponse = Val(strUser) 'Asks the user for what menu item they want to see and displays it.
            If intMainMenuResponse = 1 Then
                Rules() 'Displays rules
            ElseIf intMainMenuResponse = 2 Then
                Help() 'Displays help
            ElseIf intMainMenuResponse = 3 Then
                Objective() 'Displays objective
            ElseIf intMainMenuResponse = 4 Then
                ExitMenu() 'Displays exit  
                Exit Do 'Exits the menu if 4 is typed and starts the game.
            Else
                Console.WriteLine("Please enter a number between 1-3 to expand on menu options or enter 4 to exit the menu!") 'If user enters a value not on the menu
            End If
        Loop
        Do
            Dim intQ1Response As Integer 'User's answer to the question - a choice of going left or right.
            Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
            Console.WriteLine("")
            Console.WriteLine("Using the flame from the candle, you identify a wooden door at the other end of the room. With curiosity and dread, you decide to open it and find that you can go in two directions: left or right. Which path would you like to take?") 'The user makes a decision to go left or right and will have a different order of challenges depending on what is chosen.
            Console.WriteLine("")
            Console.WriteLine("1. Take the path going left")
            Console.WriteLine("2. Take the path going right")
            strUser = Console.ReadLine()
            intQ1Response = Val(strUser) 'Turns user's input into a value

            If intQ1Response = 1 Then 'Results for if user chooses to go left. It inserts the methods below which contain code for the game. The challenge order is different depending on the path chosen, however, the end result remains the same.
                Challenge1() 'Shows the first challenge to the user.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Slide() 'Leads user to next challenge.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Challenge3() 'Shows the second challenge to the user.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                RailCart() 'Leads user to next challenge.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Challenge2() 'Shows the third challenge to the user. 
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                ItemPuzzle() 'User must place 3 collected items. 
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Console.Clear() 'Clears past messages to make fight more organized.
                FinalBattle() 'Shows the final battle details to the user.
                ConcludingMessages() 'Congratulates the user for completing the game. 
                Credits() 'Shows the credits of the game. 
                Exit Do 'Exits loop. 
            ElseIf intQ1Response = 2 Then 'Results for if user chooses to go right. It inserts the methods below which contain code for the game. The challenge order is different depending on the path chosen, however, the end result remains the same.
                Challenge2() 'Shows first challenge to the user.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Slide() 'Leads user to next challenge.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Challenge1() 'Shows second challenge to the user.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                RailCart() 'Leads user to next challenge.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Challenge3() 'Shows third challenge to the user.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                ItemPuzzle() 'User must place 3 collected items.
                TypeToContinue() 'Waits for user to read story and continue if they are ready.
                Console.Clear() 'Clears past messages to make fight more organized.
                FinalBattle() 'Shows the final battle details to the user.
                ConcludingMessages() 'Congratulates the user for completing the game.
                Credits() 'Shows the credits of the game.
                Exit Do 'Exits loop.
            Else
                Console.WriteLine("The only routes you can take are right or left...") 'If user inputs neither 1 or 2, they are asked to re-input a valid entry.
            End If
        Loop
        Console.ReadKey()
    End Sub

    Sub Menu() 'The method for menu which contains all of the options available for the user.
        Console.WriteLine("Main Menu (Enter the number beside the option you wish to view)")
        Console.WriteLine("1. View Rules and How to Play")
        Console.WriteLine("2. View Help and Advice")
        Console.WriteLine("3. View Objective")
        Console.WriteLine("4. Exit Menu")
    End Sub

    Sub Rules() 'This expands on the rules, which is something the user can view on the menu. It explains the basic concepts and what the user must do to win.
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
        Console.WriteLine("Rules")
        Console.WriteLine("1. To proceed in the game, you will sometimes have to make decisions in terms of direction or weapon. These options will be limited and provided to you when they appear. For these responses, enter the number beside the option you want to choose.")
        Console.WriteLine("2. You must reach the exit by completing various challenges. These can range from unscrambling words, solving puzzles, and a short minigame.")
        Console.WriteLine("3. Solving challenges opens up paths that would otherwise be locked. They give you items that will help you in the future of the game. Without solving these challenges, it is not possible to complete the game.")
        Console.WriteLine("4. Once the exit is found, you will have to fight a monster, who is also the owner of the establishment and the one who trapped you inside!")
        Console.WriteLine("5. During this fight, you will have to roll a 6-sided die and the number that you roll will determine the amount of damage done to the monster. The monster will attack in the same way. Rolling a 1 does the least amount of damage, while rolling a 6 does the most. You will also get to choose which weapon you want to use during the fight.")
        Console.WriteLine("6. In the final fight, the health bar or HP of both you and the monster will be displayed and whoever loses all of their health first, will lose the fight. PLEASE NOTE: Progress is saved and dying in this fight will only restart the fight instead of starting the game all over again.")
        Console.WriteLine("7. Once you defeat the monster, you would successfully escape the building and win the game!")
        Console.WriteLine("")
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
    End Sub

    Sub Help() 'This expands on the help option from the menu and offers tips that can help the user beat the game.
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
        Console.WriteLine("Help")
        Console.WriteLine("1. Try to think creatively and outside of the box to come up with answers to the puzzles.")
        Console.WriteLine("2. Remember, the objective of the game is to escape, and it does not matter how long it takes you to answer each question!")
        Console.WriteLine("3. If you think you made the wrong decision, keep in mind that all pathways have value and will help you in some way to reach the end!")
        Console.WriteLine("")
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
    End Sub

    Sub Objective() 'This tells the user what they have to accomplish in order to beat the game. 
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
        Console.WriteLine("Your Objective")
        Console.WriteLine("Reach the exit to the building after solving puzzles, answering questions, travelling through various paths and making decisions. With continuous efforts, you will be able to get through each hurdle and use your small successes to continue moving forward. Just before you complete the game, you must defeat the final boss in a fight and if successful, you will be able to escape the building!")
        Console.WriteLine("")
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
    End Sub

    Sub ExitMenu() 'This is used to exit the menu. 
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------")
        Console.WriteLine("You have decided to exit the menu. Good luck and remember to have fun!")
        Console.WriteLine("")
    End Sub

    Sub TypeToContinue() 'This method acts as a way to organize text within the output of the game. Without it, there would be too much text and it would not look appealing. It uses ASCII borders and tells the user to enter anything to continue so that all text isn't displayed at the same time.
        Dim strContinue As String 'User enters anything to continue
        Console.WriteLine(" ")
        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        Console.WriteLine("Please type anything to continue if you are ready.")
        Console.WriteLine(" ")
        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        strUser = Console.ReadLine()
        strContinue = strUser 'Asks the user to input anything to go to the next portion of the game.
    End Sub
    Sub Challenge1() 'This method is for one of the challenges the user must complete. It is a challenge that asks the user to unscramble a word and gives them an item that is useful later on: a shiny button. 
        Dim strUnscramble As String 'User's unscrambled answer.
        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        Console.WriteLine("The walls are lined in ivy and feel sticky. Hesitantly, you stop touching them in fear of what may be crawling on them. You start moving cautiously and after a few meters, you come across a strange looking painting on the wall. There are 9 squares, with each square having 1 letter inside it. Rearrange the letters to unscramble a word and once you do, you will receive a tool that will help in your escape!") 'Offers plot and explains to the user what they must do.
        Console.WriteLine(" _____ _____ _____")
        Console.WriteLine("|     |     |     |") 'ASCII art of painting to help the user understand what they must solve.
        Console.WriteLine("|  U  |  O  |  Y  |")
        Console.WriteLine("|_____|_____|_____|")
        Console.WriteLine("|_____ _____ _____|")
        Console.WriteLine("|     |     |     |")
        Console.WriteLine("|  S  |  C  |  B  |")
        Console.WriteLine("|_____|_____|_____|")
        Console.WriteLine("|_____ _____ _____|")
        Console.WriteLine("|     |     |     |")
        Console.WriteLine("|  R  |  T  |  I  |")
        Console.WriteLine("|_____|_____|_____|")
        Do
            Console.WriteLine("")
            Console.WriteLine("Please enter the unscrambled word:")
            strUser = Console.ReadLine()
            strUnscramble = strUser
            strUnscramble = strUnscramble.ToUpper() 'Converts the user's inputted answer to capitals so that the answer can be approved no matter how it is typed out. 

            If strUnscramble = "OBSCURITY" Then 'If the answer is right, the user will be notified they were right and then be given the item. 
                Console.WriteLine("You have successfully cracked the puzzle! The correct word was OBSCURITY.")
                Console.WriteLine("")
                Console.WriteLine("The painting makes a creaking noise as it starts opening up. As dust clouds the air around you, you notice a compartment inside and put your hand inside after seeing a shine...")
                Console.WriteLine(" ")
                Console.WriteLine("Congrats! You have obtained a shiny button!") 'Receives shiny button for completing challenge
                Exit Do
            ElseIf strUnscramble = "HINT" Then 'This gives the user a hint if they type 'hint' to help get the answer.
                Console.WriteLine("O B _ C _ R _ _ Y")
            Else
                Console.WriteLine("That is incorrect! Try again! If you would like a hint, please type 'Hint'!") 'Message if answer is incorrect.
            End If
        Loop
    End Sub
    Sub Challenge2() 'This method is for another challenge that the user must complete. It is a challenge that asks the user to decode a message involving the spines of books. 
        Dim strDecode As String 'User's decoded answer.
        Dim intRandNum As Integer 'Random number for the hint.
        Dim strHint As String 'Random letter for hint
        Dim strLetters As String 'All letters of the alphabet, to be randomly chosen. 
        Console.WriteLine("The darkness starts to overwhelm your candle, but relentlessly, you continue advancing forward...")
        Console.WriteLine("Eventually, you come across a room that looks like an abandoned library or office. Surrounded by books, you notice something special about this room. Some of the books on one of the bookshelves have spines with numbers that can be decoded to letters to create something...")
        Console.WriteLine(" _________________________________________________________") 'ASCII Art of bookshelf to better help visualize.
        Console.WriteLine("||-------------------------------------------------------||")
        Console.WriteLine("||.--.    .-._                        .----.             ||")
        Console.WriteLine("|||==|____| | |___            .---.___|''''|_____.--.___ ||")
        Console.WriteLine("|||  |====| | |11 |_          |+++|=-=|_ 8_|-=+=-|==|---|||")
        Console.WriteLine("|||==|  1 | | |   | \         |   |21 |_\/_|  14 |  | ^ |||")
        Console.WriteLine("|||14|    | | |   |\ \   .--. | 8 |=-=|_/\_|-=+=-|13| ^ |||")
        Console.WriteLine("|||  |    | | |   |_\ \_( oo )|   |   |    |     |  | ^ |||")
        Console.WriteLine("|||==|====| | |xxx|  \ \ |''| |+++|=-=|''''|-=+=-|==|---|||")
        Console.WriteLine("||`--^----'-^-^---'   `-' ''  '---^---^----^-----^--^---^||")
        Console.WriteLine("||-------------------------------------------------------||")

        Do
            Console.WriteLine(" ")
            Console.WriteLine("Please enter the decoded message (or type 'Hint' for a hint):")
            strUser = Console.ReadLine()
            strDecode = strUser 'User's answer
            strDecode = strDecode.ToUpper() 'Coverts user's response to all capitals 
            If strDecode = "OBLIVION" Then 'If the user's input is oblivion, their answer is right.
                Console.WriteLine("You have successfully decoded the message! The correct message was OBLIVION.") 'Tells the user they were correct.
                Console.WriteLine("")
                Console.WriteLine("The shelf starts shaking uncontrollably and the vibration passes through the floor. One of the books falls from the shelf and lands by your feet. You pick it up and open it to a random page and a strange looking pin falls out.")
                Console.WriteLine(" ")
                Console.WriteLine("Congrats! You have obtained a butterfly hairpin!") 'Gives user the item. 
                Exit Do
            ElseIf strDecode = "HINT" Then
                Randomize()
                strLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'All letters of the alphabet. The first letter, A is equal to 0, while Z, the last letter, is equal to 25. 
                intRandNum = Int(Rnd() * 26) + 0 'Int(Rnd() * HIGH - LOW + 1) + LOW
                strHint = strLetters.Substring(intRandNum, 1) 'Randomly mentions a letter and its value using substring. It helps the user identify other letters and their values.
                Console.WriteLine(strHint & " = " & intRandNum) 'Displays random letter and its value.
            Else
                Console.WriteLine("That is incorrect! Try again! If you would like a hint, please type 'Hint'!") 'If the answer is incorrect, then displays message.
            End If
        Loop
    End Sub

    Sub Challenge3() 'This method is for another challenge that the user must complete. It is similar to whack-a-mole in which a creature will appear in a random hole and the user must hit it.
        Console.WriteLine("You reach a box-like machine with nine holes and a mallet. The darkness around you makes it appear scary, but upon closer inspection, there is nothing to be afraid of.") 'Context to challenge.
        Console.WriteLine("Suddenly, a small otherwordly creature the size of a capybara pops up from one of the holes and bites your hand. You take the mallet and decide that you must hit it before you keep going!")
        Console.WriteLine(" ")
        Console.WriteLine("    ████████████              ████████████    ") 'ASCII Art of creature
        Console.WriteLine("  ██▒▒▒▒▒▒▒▒▒▒▒▒██          ██░░░░░░░░░░░░██  ")
        Console.WriteLine("██▒▒████▒▒▒▒▒▒▒▒██████████████░░░░░░░░████░░██")
        Console.WriteLine("██▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░██▒▒▒▒▒▒██")
        Console.WriteLine("██▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░██▒▒▒▒▒▒██")
        Console.WriteLine("██▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░        ██▒▒▒▒██")
        Console.WriteLine("  ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░              ████  ")
        Console.WriteLine("    ██▒▒▒▒██████▒▒▒▒▒▒░░      ██████    ██    ")
        Console.WriteLine("    ██▒▒████    ██░░░░      ██    ████  ██    ")
        Console.WriteLine("  ██▒▒▒▒████    ██░░░░      ██    ████    ██  ")
        Console.WriteLine("  ██░░░░██  ██████░░        ██████  ██    ██  ")
        Console.WriteLine("  ████░░░░██████░░░░          ██████    ████  ")
        Console.WriteLine("  ██░░░░░░░░░░░░░░    ██                  ██  ")
        Console.WriteLine("  ████░░░░░░░░░░                        ████  ")
        Console.WriteLine("  ██░░░░░░░░░░  ██    ██    ██            ██  ")
        Console.WriteLine("    ██░░░░░░      ████  ████            ██    ")
        Console.WriteLine("    ████▒▒░░                      ░░░░████    ")
        Console.WriteLine("    ██▒▒░░    ██              ██    ░░░░██    ")
        Console.WriteLine("    ██░░░░  ░░░░██          ██░░░░  ░░░░██    ")
        Console.WriteLine("    ██░░  ██░░░░██          ██░░░░██  ░░██    ")
        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        Console.WriteLine(" _________________________________________________")
        Console.WriteLine("|     o  o      |       o  o     |      o  o      |") 'ASCII Art of the 9 holes and squares that the creature may show up in.
        Console.WriteLine("|  o        o   |    o        o  |   o        o   |")
        Console.WriteLine("| o    1     o  |   o    2     o |  o    3     o  |")
        Console.WriteLine("| o          o  |   o          o |  o          o  |")
        Console.WriteLine("|  o        o   |    o        o  |   o        o   |")
        Console.WriteLine("|     o  o      |       o  o     |      o  o      |")
        Console.WriteLine("|-------------------------------------------------|")
        Console.WriteLine("|     o  o      |       o  o     |      o  o      |")
        Console.WriteLine("|  o        o   |    o        o  |   o        o   |")
        Console.WriteLine("| o    4     o  |   o    5     o |  o    6     o  |")
        Console.WriteLine("| o          o  |   o          o |  o          o  |")
        Console.WriteLine("|  o        o   |    o        o  |   o        o   |")
        Console.WriteLine("|     o  o      |       o  o     |      o  o      |")
        Console.WriteLine("|-------------------------------------------------|")
        Console.WriteLine("|     o  o      |       o  o     |      o  o      |")
        Console.WriteLine("|  o        o   |    o        o  |   o        o   |")
        Console.WriteLine("| o    7     o  |   o    8     o |  o    9     o  |")
        Console.WriteLine("| o          o  |   o          o |  o          o  |")
        Console.WriteLine("|  o        o   |    o        o  |   o        o   |")
        Console.WriteLine("|     o  o      |       o  o     |      o  o      |")
        Console.WriteLine("|_________________________________________________|")
        Console.WriteLine(" ")
        Console.WriteLine("The small creature will pop up in 1 out of the 9 holes.") 'Rules of the challenge. 
        Console.WriteLine(" ")
        Console.WriteLine("In order to beat it, you must successfully guess where it will pop up and hit it! Doing so will let you get revenge and will be one step closer to escaping! Holding the mallet, you point it toward one of the holes.")
        Dim intRandNum2 As Integer 'The hole that the animal appears in.
        Dim intHoleChosen As Integer 'The user's decision of which hole they want to hit

        Randomize()
        Do
            Console.WriteLine("Which hole will you hit?")
            strUser = Console.ReadLine()
            intHoleChosen = Val(strUser) 'The hole that the user decides to hit.
            Randomize()
            intRandNum2 = Int(Rnd() * 9) + 1 'The hole that the creature will show up in randomly.
            If intHoleChosen <> intRandNum2 Then 'If user's choice and hole are different, the loop will continue running.
                Console.WriteLine("You hit hole number " & intHoleChosen & " and the creature popped up in hole number " & intRandNum2 & "!") 'Displays message when user gets it wrong.

            ElseIf intHoleChosen = intRandNum2 Then
                Console.WriteLine("You hit hole number " & intHoleChosen & " and the creature popped up in hole number " & intRandNum2 & "!") 'Displays message when user gets it right.
            End If
        Loop While intHoleChosen <> intRandNum2 'The loop stops when the choice is the same as the hole. 

        Console.WriteLine("You successfully hit the creature with your mallet! The strange being fell to the ground and stopped moving around.")
        Console.WriteLine("It opened its mouth and revealed an unique item that reminded you of the oceans back home...")
        Console.WriteLine(" ")
        Console.WriteLine("Congrats! You have earned an elegant sapphire gem!") 'User gets an item that can be used later on.
    End Sub

    Sub ItemPuzzle()
        Dim strSlotChoice, strSlotChoice2, strSlotChoice3 As String 'The variables represent the 3 slots the user has to put items into. 
        Console.WriteLine("After progressing farther into the darkness, you reach a brick wall with a stand next to it. There is a closed metal door shut right in front of you.") 'Context
        Console.WriteLine("  ________") 'ASCII Art of a door to help user visualize.
        Console.WriteLine(" / ______ \")
        Console.WriteLine(" || _  _ ||")
        Console.WriteLine(" ||| || |||")
        Console.WriteLine(" |||_||_|||")
        Console.WriteLine(" || _  _o||")
        Console.WriteLine(" ||| || |||")
        Console.WriteLine(" |||_||_|||")
        Console.WriteLine(" ||______||")
        Console.WriteLine("/__________\")
        Console.WriteLine("|__________|")
        Console.WriteLine(" ")
        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        Console.WriteLine("With further inspection, there are three empty slots on the stand where it looks like items must be placed.")
        Console.WriteLine(" ")
        Console.WriteLine("Place the three items you have collected from the challenges into each slot.")
        Console.WriteLine(" ")
        Do 'Continues loop until user enters the correct item.
            Console.WriteLine("Enter an item into slot 1. The shape looks like a butterfly!")
            strUser = Console.ReadLine()
            strSlotChoice = strUser 'User enters item 1.
            strSlotChoice = strSlotChoice.ToUpper() 'String is converted to all capitals to accept the answer.

            If strSlotChoice = "BUTTERFLY HAIRPIN" Then
                Console.WriteLine("Successfully placed!") 'Displays if user enters the right item.
                Exit Do 'Exits the loop and goes onto the next.
            Else
                Console.WriteLine("That item does not fit into the slot!") 'Displays if user enters the wrong item.
            End If
        Loop

        Do
            Console.WriteLine("Enter an item into slot 2. The shape looks like a small circle!")
            strUser = Console.ReadLine()
            strSlotChoice2 = strUser 'User enters item 2. 
            strSlotChoice2 = strSlotChoice2.ToUpper() 'String is converted to all capitals to accept the answer.

            If strSlotChoice2 = "SHINY BUTTON" Then
                Console.WriteLine("Successfully placed!") 'Displays if user enters the right item. 
                Exit Do 'Exits loop and goes onto the next.
            Else
                Console.WriteLine("That item does not fit into the slot!") 'Displays if user enters the wrong item. 
            End If
        Loop
        Do
            Console.WriteLine("Enter an item into slot 3. The shape looks like the size of a small rock!")
            strUser = Console.ReadLine()
            strSlotChoice3 = strUser 'User enters item 2. 
            strSlotChoice3 = strSlotChoice3.ToUpper() 'String is converted to all capitals to accept the answer.

            If strSlotChoice3 = "ELEGANT SAPPHIRE GEM" Then
                Console.WriteLine("Successfully placed!") 'Displays if user enters the right item. 
                Exit Do 'Exits loop
            Else
                Console.WriteLine("That item does not fit into the slot!") 'Displays if user enters the wrong item. 
            End If
        Loop

        Console.WriteLine("(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸.·´¯`·.¸¸.·´¯)(¯`·.¸¸")
        Console.WriteLine(" ")
        Console.WriteLine("The door starts to open wide...") 'Context
        Console.WriteLine(" ")
        Console.WriteLine("A bright white light seeps through and hits your face. While blinded by the shine, you try looking, but can't see anything...")
        Console.WriteLine("")
        Console.WriteLine("Suddenly, you become extremely dizzy and start falling to the ground. You can't control your body anymore and your surroundings become dark as your eyes close on their own. In your final seconds, you think you saw a figure on the other side of that door...")
        Console.WriteLine(" ")
    End Sub

    Sub Slide()
        Console.WriteLine("Through further exploration, you find a metal slide and a small gate to go down. You think there couldn't possibly be a better choice but to ride it to the lower floor.")
        Console.WriteLine(" ")
        Console.WriteLine("██████████████████████████████████████") 'ASCII Art of pipe
        Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██")
        Console.WriteLine("██▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░░░██")
        Console.WriteLine("██░░▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░██")
        Console.WriteLine("██░░▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░░░██")
        Console.WriteLine("██░░▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░██")
        Console.WriteLine("  ██████████████████████████████████  ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒▒▒░░▒▒░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒░░▒▒░░░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒▒▒░░▒▒░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒░░▒▒░░░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒▒▒░░▒▒░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒░░▒▒░░░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒▒▒░░▒▒░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒░░▒▒░░░░██    ")
        Console.WriteLine("    ██░░▒▒░░░░░░▒▒░░▒▒▒▒▒▒░░▒▒░░██    ")
    End Sub

    Sub RailCart()
        Console.WriteLine("You find a rail with a trolley on it. It goes downhill into the abyss, but it's the only path available other than going back. You crawl into the cart and push yourself forward until you rapidly gain speed.")
        Console.WriteLine(" ")
        Console.WriteLine("           /=/") 'ASCII Art of cart on a rail
        Console.WriteLine("        __/=/")
        Console.WriteLine("       /::/|")
        Console.WriteLine("     _/::/ /")
        Console.WriteLine("    /_~/||/")
        Console.WriteLine("   [__]/_/'")
        Console.WriteLine("      /=/")
        Console.WriteLine("     /=/")
    End Sub

    Sub FinalBattle()
        Do
            Dim intWeaponChoice As String 'The variable represents the weapon the user chooses.
            Dim strRestartFight As String 'The variable represents anything the user says to restart the fight. 
            Console.WriteLine("You wake up to a loud ringing noise in your ear. Confused, you try to get up, but your limbs feel very weak. With determination, you manage to stand up on both feet shaking, but still up regardless.")
            Console.WriteLine(" ")
            Console.WriteLine("Then all of a sudden, a large monster the size of two telephone poles creeps up from within the abyss that you assume is its cave. Its large grin and sharp teeth are menacing, and slender body looks straight out of a horror film... This must be the owner of the building you were stuck in and the thing that trapped you inside!")
            Console.WriteLine(" ")
            Console.WriteLine("     .      .") 'ASCII Art of the monster user has to fight.
            Console.WriteLine("     |\____/|")
            Console.WriteLine("    (\|----|/)")
            Console.WriteLine("     \ 0  0 /")
            Console.WriteLine("      |    |")
            Console.WriteLine("   ___/\../\____")
            Console.WriteLine("  /     --       \")
            Console.WriteLine(" /  \         /   \")
            Console.WriteLine("|    \___/___/(   |")
            Console.WriteLine("\   /|  }{   | \  )")
            Console.WriteLine(" \  ||__}{__|  |  |")
            Console.WriteLine("  \  |;;;;;;;\  \ / \_______")
            Console.WriteLine("   \ /;;;;;;;;| [,,[|======'")
            Console.WriteLine("     |;;;;;;/ |     /")
            Console.WriteLine("     ||;;|\   |")
            Console.WriteLine("     ||;;/|   /")
            Console.WriteLine("     \_|:||__|")
            Console.WriteLine("      \ ;||  /")
            Console.WriteLine("      |= || =|")
            Console.WriteLine("      |= /\ =|")
            Console.WriteLine("      /_/  \_\")
            Console.WriteLine(" ")
            Console.WriteLine("Filled with anger, you decide that you must take it out and escape this place alive no matter what it takes! Looking around you, you find two weapons:") 'Weapon choices.
            Console.WriteLine("1. Axe")
            Console.WriteLine("2. Bow and Arrow")
            Console.WriteLine(" ")
            Console.WriteLine("Select one of the weapons (enter number beside weapon of choice) to use in your fight against the monster!")
            strUser = Console.ReadLine()
            intWeaponChoice = Val(strUser) 'User enters weapon selection to use in battle.

            If intWeaponChoice = 1 Then 'If the user enters 1, displays messages.
                Console.WriteLine(" ")
                Console.WriteLine("You have chosen the axe!")
                Console.WriteLine(" ")
                Console.WriteLine("*A reminder that during this fight, you will have to roll a 6-sided die and depending on what it rolls on, you will deal damage accordingly. Rolling a 6 deals the most damage while rolling a 1 does the least. In addition, you will be given a choice to do a normal slash or a special attack! Doing a special attack will do more damage, however it has a cooldown of 2 moves!*") 'Re-explins the rules of the battle to the user.
                Console.WriteLine(" ")
                Dim intAttackChoice As Integer 'The variable represents the attack the user wants to do. 
                Dim isCooldown As Boolean = False 'Sets cooldown to false, then becomes true when move is done. 
                Dim intCounter As Integer = 0 'The variable acts as a counter that is used to force a cooldown on the special attack. 
                Dim intRoll, intMonsterRoll As Integer 'The variables represent the rolls of the monster and user.
                Dim intDamage, intMonsterDamage As Integer 'The variable represents the damage dealt to each other.
                Dim intUserHP As Integer = 100 'The user's HP before the battle.
                Dim intMonsterHP As Integer = 100 'The monster's HP before the battle. 
                Console.WriteLine("Your HP: " & intUserHP) 'Displays user's HP initially
                Console.WriteLine("Monster's HP: " & intMonsterHP) 'Displays Monster's HP initially

                Do While intUserHP > 0 And intMonsterHP > 0 'The loop will run as long as the HP of the monster and user is above 0. This means if any HP is below 1, the battle will stop.
                    Console.WriteLine("---------------------------------------------------------------------")
                    Console.WriteLine(" ")
                    Console.WriteLine("What attack would you like to do? (Enter the number beside the attack)")
                    Console.WriteLine("1. Slash of the Heavens")
                    Console.WriteLine("2. Special Attack - Wrath of Achilles")
                    Console.WriteLine(" ")
                    strUser = Console.ReadLine()
                    intAttackChoice = Val(strUser) 'User enters the attack choice they want. 

                    Randomize()
                    intRoll = Int(Rnd() * 6) + 1 'Int(Rnd()*HIGH-LOW + 1) + LOW with HIGH = 6, LOW = 1 for user's roll.
                    Select Case intRoll 'Each case shows damage for each roll achieved.
                        Case 1
                            intDamage = 8
                        Case 2
                            intDamage = 13
                        Case 3
                            intDamage = 19
                        Case 4
                            intDamage = 25
                        Case 5
                            intDamage = 32
                        Case 6
                            intDamage = 38
                    End Select

                    If intAttackChoice = 1 Then 'Displays if attack choice is 1 or normal attack. 
                        intMonsterHP = intMonsterHP - intDamage 'Subtracts monster's HP by the damage dealt.
                        Console.WriteLine("You rolled a " & intRoll & "!") 'Displays user's roll.
                        Console.WriteLine("Slash of the Heavens dealt " & intDamage & " damage!") 'Displays damage dealt.
                        Console.WriteLine("Monster's Remaining HP: " & intMonsterHP) 'Displays monster's HP. 

                        intMonsterRoll = Int(Rnd() * 6) + 1 'Int(Rnd()*HIGH-LOW+1)+LOW for monster's roll.
                        Select Case intMonsterRoll 'Each case shows damage for each roll achieved.
                            Case 1
                                intMonsterDamage = 9
                            Case 2
                                intMonsterDamage = 14
                            Case 3
                                intMonsterDamage = 21
                            Case 4
                                intMonsterDamage = 27
                            Case 5
                                intMonsterDamage = 35
                            Case 6
                                intMonsterDamage = 39
                        End Select

                        Console.WriteLine(" ")
                        Console.WriteLine("The monster rolled a " & intMonsterRoll & "!") 'Displays monster's roll. 
                        Console.WriteLine("The monster hit you dealing " & intMonsterDamage & " damage!") 'Displays monster's damage. 
                        intUserHP = intUserHP - intMonsterDamage 'Subtracts user's HP by damage dealt by monster.
                        Console.WriteLine("Your Remaining HP: " & intUserHP) 'Displays user's HP.

                        'ElseIf intAttackChoice = 2 And intCounter Mod 3 <> 0 Then 'Cooldown if 3 moves did not pass since last special attack. 
                        'Console.WriteLine("You have a cooldown for a special attack!")

                        If intCounter > 0 Then 'Subtracts 1 from counter until it equals 0.
                            intCounter -= 1
                        ElseIf intCounter = 0 Then 'When counter is equal to 0, cooldown is set to false again and is reset.
                            isCooldown = False
                        Else
                            intCounter = 2 'If counter goes below 0, it is set back to 2.
                        End If

                    ElseIf intAttackChoice = 2 And isCooldown = False Then 'Displays if user chooses second attack - special attack. 
                        intDamage = intDamage + 9 'Adds 9 to damage to increase output. 
                        intMonsterHP = intMonsterHP - intDamage 'Subtracts monster's HP by damage.
                        Console.WriteLine("You rolled a " & intRoll & "!") 'User's roll is displayed. 
                        Console.WriteLine("CRITICAL HIT! Wrath of Achilles dealt " & intDamage & " damage!") 'Damage dealt to monster is displayed. 
                        Console.WriteLine("Monster's Remaining HP: " & intMonsterHP) 'Monster's HP is displayed. 


                        intMonsterRoll = Int(Rnd() * 6) + 1 'Int(Rnd()*HIGH-LOW+1)+LOW for monster's roll.
                        Select Case intMonsterRoll'Each case shows damage for each roll achieved.
                            Case 1
                                intMonsterDamage = 9
                            Case 2
                                intMonsterDamage = 14
                            Case 3
                                intMonsterDamage = 21
                            Case 4
                                intMonsterDamage = 27
                            Case 5
                                intMonsterDamage = 35
                            Case 6
                                intMonsterDamage = 39
                        End Select

                        Console.WriteLine(" ")
                        Console.WriteLine("The monster rolled a " & intMonsterRoll & "!") 'Displays monster's roll.
                        Console.WriteLine("The monster hit you dealing " & intMonsterDamage & " damage!") 'Displays damage dealt by monster.
                        intUserHP = intUserHP - intMonsterDamage 'Subtracts HP by damage dealt.
                        Console.WriteLine("Your Remaining HP: " & intUserHP) 'Displays user's HP.

                        isCooldown = True 'Sets cooldown to true.
                        intCounter = 2 'Sets counter to 2. 


                        If intCounter > 0 Then 'Subtracts 1 from counter until it equals 0. 
                            intCounter -= 1
                        ElseIf intCounter = 0 Then 'When counter is equal to 0, cooldown is set to false and is reset. 
                            isCooldown = False
                        Else 'Sets counter to 2 when it falls below 0. 
                            intCounter = 2
                        End If

                    ElseIf isCooldown = True Then 'User is told they have a cooldown if it is set as true.
                        Console.WriteLine("You have a cooldown on the special attack!")
                    Else 'If user enters a move not on the options.
                        Console.WriteLine("Choose from one of the moves available!")
                    End If
                Loop


                If intMonsterHP <= 0 Then 'If monster's HP is below 0, they are told they won.
                    Console.WriteLine("Congratulations! You defeated the monster!")
                    Exit Do

                ElseIf intUserHP <= 0 Then 'Displays if user's HP is below 0 and restarts the game. 
                    Console.WriteLine("You have died! You must restart the fight again. Please type anything to start over.")
                    strUser = Console.ReadLine()
                    strRestartFight = strUser
                    Console.Clear()
                End If

            ElseIf intWeaponChoice = 2 Then 'If the user enters 2, displays messages.
                Console.WriteLine(" ")
                Console.WriteLine("You have chosen the bow and arrow!")
                Console.WriteLine(" ")
                Console.WriteLine("*A reminder that during this fight, you will have to roll a 6-sided die and depending on what it rolls on, you will deal damage accordingly. Rolling a 6 deals the most damage while rolling a 1 does the least. In addition, you will be given a choice to do a normal slash or a special attack! Doing a special attack will do more damage, however it has a cooldown of 2 moves!*")
                Console.WriteLine(" ")
                Dim intAttackChoice As Integer 'The variable represents the attack the user wants to do. 
                Dim isCooldown As Boolean = False 'Sets cooldown to false, then becomes true when move is done. 
                Dim intCounter As Integer = 0 'The variable acts as a counter that is used to force a cooldown on the special attack. 
                Dim intRoll, intMonsterRoll As Integer 'The variables represent the rolls of the monster and user.
                Dim intDamage, intMonsterDamage As Integer 'The variable represents the damage dealt to each other.
                Dim intUserHP As Integer = 100 'The user's HP before the battle.
                Dim intMonsterHP As Integer = 100 'The monster's HP before the battle. 
                Console.WriteLine("Your HP: " & intUserHP) 'Displays user's HP initially
                Console.WriteLine("Monster's HP: " & intMonsterHP) 'Displays Monster's HP initially

                Do While intUserHP > 0 And intMonsterHP > 0 'The loop will run as long as the HP of the monster and user is above 0. This means if any HP is below 1, the battle will stop.
                    Console.WriteLine("---------------------------------------------------------------------")
                    Console.WriteLine(" ")
                    Console.WriteLine("What attack would you like to do? (Enter the number beside the attack)")
                    Console.WriteLine("1. Point Blank Shot")
                    Console.WriteLine("2. Special Attack - Rain of a Thousand Arrows")
                    Console.WriteLine(" ")
                    strUser = Console.ReadLine()
                    intAttackChoice = Val(strUser) 'Converts user's attack to a value. 

                    Randomize()
                    intRoll = Int(Rnd() * 6) + 1 'Int(Rnd()*HIGH-LOW + 1) + LOW with HIGH = 6, LOW = 1 for user's roll.
                    Select Case intRoll
                        Case 1
                            intDamage = 8
                        Case 2
                            intDamage = 13
                        Case 3
                            intDamage = 19
                        Case 4
                            intDamage = 25
                        Case 5
                            intDamage = 32
                        Case 6
                            intDamage = 38
                    End Select

                    If intAttackChoice = 1 Then 'Displays if attack choice is 1 or normal attack. 
                        intMonsterHP = intMonsterHP - intDamage
                        Console.WriteLine("You rolled a " & intRoll & "!")
                        Console.WriteLine("Point Blank Shot dealt " & intDamage & " damage!")
                        Console.WriteLine("Monster's Remaining HP: " & intMonsterHP)

                        intMonsterRoll = Int(Rnd() * 6) + 1 'Int(Rnd()*HIGH-LOW + 1) + LOW with HIGH = 6, LOW = 1 for monster's roll.
                        Select Case intMonsterRoll 'Displays damage dealt by monster depending on the roll. 
                            Case 1
                                intMonsterDamage = 9
                            Case 2
                                intMonsterDamage = 14
                            Case 3
                                intMonsterDamage = 21
                            Case 4
                                intMonsterDamage = 27
                            Case 5
                                intMonsterDamage = 35
                            Case 6
                                intMonsterDamage = 39
                        End Select

                        Console.WriteLine(" ")
                        Console.WriteLine("The monster rolled a " & intMonsterRoll & "!") 'Displays monster's roll. 
                        Console.WriteLine("The monster hit you dealing " & intMonsterDamage & " damage!") 'Displays damage dealt by monster. 
                        intUserHP = intUserHP - intMonsterDamage 'Calculates user's HP after subtracting damage dealt by monster. 
                        Console.WriteLine("Your Remaining HP: " & intUserHP) 'Displays user's HP.

                        If intCounter > 0 Then 'Subtracts 1 from counter until it equals 0.
                            intCounter -= 1
                        ElseIf intCounter = 0 Then 'When counter is equal to 0, cooldown is reset and set to false.
                            isCooldown = False
                        Else 'Counter is set to 2 if it falls below 0. 
                            intCounter = 2
                        End If

                    ElseIf intAttackChoice = 2 And isCooldown = False Then 'Displays if user chooses second attack - special attack. 
                        intDamage = intDamage + 9 'Adds 9 to damage to increase output. 
                        intMonsterHP = intMonsterHP - intDamage 'Calculates monster's remaining HP. 

                        Console.WriteLine("You rolled a " & intRoll & "!")
                        Console.WriteLine("CRITICAL HIT! Rain of a Thousand Arrows dealt " & intDamage & " damage!")
                        Console.WriteLine("Monster's Remaining HP: " & intMonsterHP)
                        intCounter = intCounter + 1

                        intMonsterRoll = Int(Rnd() * 6) + 1
                        Select Case intMonsterRoll
                            Case 1
                                intMonsterDamage = 9
                            Case 2
                                intMonsterDamage = 14
                            Case 3
                                intMonsterDamage = 21
                            Case 4
                                intMonsterDamage = 27
                            Case 5
                                intMonsterDamage = 35
                            Case 6
                                intMonsterDamage = 39
                        End Select

                        Console.WriteLine(" ")
                        Console.WriteLine("The monster rolled a " & intMonsterRoll & "!")
                        Console.WriteLine("The monster hit you dealing " & intMonsterDamage & " damage!")
                        intUserHP = intUserHP - intMonsterDamage
                        Console.WriteLine("Your Remaining HP: " & intUserHP)

                        isCooldown = True 'Sets cooldown to true.
                        intCounter = 2 'Sets counter to 2. 

                        If intCounter > 0 Then 'Subtracts 1 from counter.
                            intCounter -= 1
                        ElseIf intCounter = 0 Then 'If counter is 0, cooldown is reset and set to false.
                            isCooldown = False
                        Else 'Sets counter to 2 if it falls below 0. 
                            intCounter = 2
                        End If

                    ElseIf isCooldown = True Then 'Tells user they have a cooldown.
                        Console.WriteLine("You have a cooldown on the special attack!")
                    Else 'Displays if user does not enter a valid entry.
                        Console.WriteLine("Choose from one of the moves available!")
                    End If
                Loop

                If intMonsterHP <= 0 Then 'If monster's HP falls below 0, the user wins and is congratulated.
                    Console.WriteLine(" ")
                    Console.WriteLine("Congratulations! You defeated the monster!")
                    Exit Do 'Exits loop if user wins. 

                ElseIf intUserHP <= 0 Then 'If the user's HP falls below 0, they must restart the fight. 
                    Console.WriteLine(" ")
                    Console.WriteLine("You have died! You must restart the fight again. Please type anything to start over.")
                    strUser = Console.ReadLine()
                    strRestartFight = strUser 'User enters anything to restart.
                    Console.Clear() 'Console is cleared for better viewing. 
                End If

            Else 'Displays if user does not choose a valid weapon. 
                Console.WriteLine("You must choose from one of the available weapons!")
            End If
        Loop
    End Sub

    Sub ConcludingMessages() 'Concludes the game and congratulates user for winning. 
        Console.WriteLine("                                   .''.       ") 'ASCII Art of fireworks to show congratulations. 
        Console.WriteLine("       .''.      .        *''*    :_\/_:     . ")
        Console.WriteLine("      :_\/_:   _\(/_  .:.*_\/_*   : /\ :  .'.:.'.")
        Console.WriteLine("  .''.: /\ :   ./)\   ':'* /\ * :  '..'.  -=:o:=-")
        Console.WriteLine(" :_\/_:'.:::.    ' *''*    * '.\'/.' _\(/_'.':'.'")
        Console.WriteLine(" : /\ : :::::     *_\/_*     -= o =-  /)\    '  *")
        Console.WriteLine("  '..'  ':::'     * /\ *     .'/.\'.   '")
        Console.WriteLine("      *            *..*         :")
        Console.WriteLine("------------------CONGRATULATIONS!------------------") 'User is congratulated for completing the game and the plot is concluded. 
        Console.WriteLine("The monster screams in agony as it starts disintegrating from your final blow. The darkness disappears and you finally reach the bright light that was emanating from the door. Your memories flood back and you remember that you sacrificed yourself to save the world and got trapped in this establishment as a result.")
        Console.WriteLine(" ")
        Console.WriteLine("You have successfully defeated the monster guarding the exit and successfully escaped the building! Thank you for playing! The credits for the game are found below!")
    End Sub

    Sub Credits() 'Credits are displayed to the user.after they beat the game. 
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(".--..--..--..-.--..--..--..CREDITS.--..--..--..-..--..--..--.")
        Console.WriteLine(" ")
        Console.WriteLine("        .--..--..--..--.PROGRAMMING.--..--..--..--.")
        Console.WriteLine("                        Ishraq Alam")
        Console.WriteLine(" ")
        Console.WriteLine("           .--..--..--..--.DESIGN.--..--..--..--.")
        Console.WriteLine("                        Ishraq Alam")
        Console.WriteLine(" ")
        Console.WriteLine("            .--..--..--..--.STORY.--..--..--..--.")
        Console.WriteLine("                        Ishraq Alam")
        Console.WriteLine(" ")
        Console.WriteLine("         .--..--..--..--.DEVELOPMENT.--..--..--..--.")
        Console.WriteLine("                        Ishraq Alam")
        Console.WriteLine(" ")
        Console.WriteLine("         .--..--..--.PROGRAMMING LANGUAGE.--..--..--.")
        Console.WriteLine("                        Visual Basic")


    End Sub
End Module
