# Gold Badge Challenges
### Elijah v. Wood
---

Below is the list of challenges I have worked on and some explanations for choices therein.

## Challenge 1
**Cafe**
- It feels a little presumptious to say this challenge was easy given the several mistakes I made in the process, but I never felt like I was doing anything new.
- I have yet to figure out how to compile a code that won't let you proceed until you give a proper value for the ID(menu number). So not only is it possible to give two items the same menu number, but this leads to an issue where deleting a menu item is not up to you if there are multiple versions of it. If the console lets you choose what to delete, then I fixed it but forgot to update the Readme.

## Challenge 2
**Claims**
- Claims felt really similar to the Cafe challenge, so I was glad to be able to kind of 'clean up' the logic of what is very similar code.
- I hadn't worked with a Queue before, besides the work we did for our notes, but I think I did well enough with it.

## Challenge 3
**Badges**
- I hated this.
- I think spent the most time with this code, but most of that time was giving myself a concussion and my wall a head-shaped dent.
- I didn't know how to work with dictionaries before this and I'm not sure I have the best understanding after either. Method construction was difficult for me. It all got easier once I got to the Console, but it was very hard to plan ahead since I felt like I had no idea what I was doing.
- I also couldn't figure out if I should make a List of doors or make a string that acts like a list of doors. I decided on the string because it was less work and could theoretically be used to open doors if the door was performing a `.Contains(doorname)` on the string. I think missing the forrest as I thought about it, but knowing how it would apply to a real world app helps me think about how to code it.
-again no way to ensure any badge ID is unique, but someday I'll figure out how to stop that from giving me compile time errors.

## Challenge 4
**Outings**
- I don't care if Outings was supposed to be difficult but everything felt like a breath of fresh air after badges.
- I like making properties that contain logic and that was fun to do with the Outing Class.
- I couldn't decide whether or not to make the Event type an enum or inherited classes initially. I decided an Enum was better because it made for smoother coding around my user input. Though this kind of leads to a fun issue where an Event type can be none as that was a safer default than an arbitrary set to something the user didn't intend. If I have time before it's due, I'll add a case to look at type none events as well. 
