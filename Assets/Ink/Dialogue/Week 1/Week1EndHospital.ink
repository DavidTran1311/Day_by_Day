Dad! You came! #speaker:George #portrait:george_neutral
Hey, buddy. #speaker:Mr. Davis #portrait:davis_neutral
... #speaker:Lily #portrait:lily_neutral
Mom was just reading me a story. #speaker:George #portrait:george_neutral
Yeah? You really love books, don't you? #speaker:Mr. Davis #portrait:davis_neutral
Mhm! They're nice to listen to, but mom's not a very good storyteller :P #speaker:George #portrait:george_neutral
Hey! Next time I won't read to you then. #speaker:Lily #portrait:lily_neutral
Wait! I didn't mean it! Mommmm... #speaker:George #portrait:george_neutral
Heh.. so, how you feeling, bud? #speaker:Mr. Davis #portrait:davis_neutral
A little tired... #speaker:George #portrait:george_neutral
...but better now that you're here! #speaker:George #portrait:george_neutral
+ That's great, buddy! #speaker:Mr. Davis #portrait:davis_neutral
 -> talk
+ ... #speaker:Mr. Davis #portrait:davis_neutral
 -> talk

=== talk ===
...
Hey, George, I have to talk to your dad for a second. #speaker:Lily #portrait:lily_neutral
...oh. #speaker:George #portrait:george_neutral
...okay mom. #speaker:George #portrait:george_neutral

...
You came. #speaker:Lily #portrait:lily_neutral
+ Yeah. #speaker:Mr. Davis #portrait:davis_neutral
 -> listen
+ Why wouldn't I? #speaker:Mr. Davis #portrait:davis_neutral
 -> listen
 
 === listen ===
 I don't know, I just thought you wouldn't listen to me. #speaker:Lily #portrait:lily_neutral
 Wouldn't be the first time. #speaker:Lily #portrait:lily_neutral
 + Did you bring me here just to get angry at me? #speaker:Mr. Davis #portrait:davis_neutral
  -> angry
 + Don't be so surprised. #speaker:Mr. Davis #portrait:davis_neutral
  -> surprised
 + ... #speaker:Mr. Davis #portrait:davis_neutral
 -> unspoken  

=== unspoken ===
...sigh... #speaker:Lily #portrait:lily_neutral
I get that you have a job and it's the only thing keeping George here. #speaker:Lily #portrait:lily_neutral
... #speaker:Lily #portrait:lily_neutral
Look, I don't want to get into this right now. #speaker:Lily #portrait:lily_neutral
+ ...okay. What did you need to tell me? #speaker:Mr. Davis #portrait:davis_neutral
 -> condition
+ ...sooo, how's George? #speaker:Mr. Davis #portrait:davis_neutral
 -> condition

=== angry ===
...no. #speaker:Lily #portrait:lily_neutral
But, how can I not? #speaker:Lily #portrait:lily_neutral
This is the first time you come here in weeks. #speaker:Lily #portrait:lily_neutral
I get that you have a job and it's the only thing keeping George here. #speaker:Lily #portrait:lily_neutral
...sigh... #speaker:Lily #portrait:lily_neutral
I don't want to get into this right now. #speaker:Lily #portrait:lily_neutral
+ Okay, fine. But I'm here now.  #speaker:Mr. Davis #portrait:davis_neutral
What did you need to tell me? #speaker:Mr. Davis #portrait:davis_neutral
 -> condition
+ Good. #speaker:Mr. Davis #portrait:davis_neutral
So, what's going on? Is George okay? #speaker:Mr. Davis #portrait:davis_neutral
 -> condition

=== surprised ===
How can I not? #speaker:Lily #portrait:lily_neutral
This is the first time you've been here in weeks. #speaker:Lily #portrait:lily_neutral
I get that you have job and it's the only thing keeping George here. #speaker:Lily #portrait:lily_neutral
...sigh... #speaker:Lily #portrait:lily_neutral
I don't want to get into this right now. #speaker:Lily #portrait:lily_neutral
I'm too tired for this. #speaker:Lily #portrait:lily_neutral
We're here for George anyway. #speaker:Lily #portrait:lily_neutral
+ Right, so what did you need to tell me? #speaker:Mr. Davis #portrait:davis_neutral
 -> condition
+ How is he? #speaker:Mr. Davis #portrait:davis_neutral
 -> condition

=== condition ===
The doctor says his condition is worsening. #speaker:Lily #portrait:lily_neutral
I- I don't know how long he has. #speaker:Lily #portrait:lily_neutral
Didn't the doctor say that he was looking better? #speaker:Mr. Davis #portrait:davis_neutral
I know, I know. #speaker:Lily #portrait:lily_neutral
She said something about the leukemia and how the treatment isn't going well. #speaker:Mr. Davis #portrait:davis_neutral #speaker:Lily #portrait:lily_neutral
I don't know how long I can go like this. #speaker:Lily #portrait:lily_neutral
+ What is that supposed to mean? #speaker:Mr. Davis #portrait:davis_neutral
 -> supposedToMean
+ ... #speaker:Mr. Davis #portrait:davis_neutral
 -> quiet


=== supposedToMean ===
I'm just saying, we have to think about the situation if something, y'know, bad happens. #speaker:Lily #portrait:lily_neutral
+ I'm not thinking about that. #speaker:Mr. Davis #portrait:davis_neutral
 He's my son. #speaker:Mr. Davis #portrait:davis_neutral
 I don't want to think that anything will happen to my son. #speaker:Mr. Davis #portrait:davis_neutral
 He still has time. #speaker:Mr. Davis #portrait:davis_neutral
 -> possibility

+ How can you think that? #speaker:Mr. Davis #portrait:davis_neutral
He's my son. #speaker:Mr. Davis #portrait:davis_neutral
I can't believe you'd think something like that. #speaker:Mr. Davis #portrait:davis_neutral
We're far from that. He still has time. #speaker:Mr. Davis #portrait:davis_neutral
 -> possibility

=== possibility ===
 Oh, so now you're going to act like a father? #speaker:Lily #portrait:lily_neutral
 He's my son too. #speaker:Lily #portrait:lily_neutral
 We have to consider it as a possibility. #speaker:Lily #portrait:lily_neutral
 I'm just preparing us for what might happen. #speaker:Lily #portrait:lily_neutral
 I'm not going to let it go like that without even seeing what can be done. #speaker:Mr. Davis #portrait:davis_neutral
 I won't. #speaker:Mr. Davis #portrait:davis_neutral
 He's too young. #speaker:Mr. Davis #portrait:davis_neutral
 There's so much for him to see. #speaker:Mr. Davis #portrait:davis_neutral
 ... #speaker:Lily #portrait:lily_neutral
 I want to talk to the doctor. #speaker:Mr. Davis #portrait:davis_neutral
 There must be something more that can be done. #speaker:Mr. Davis #portrait:davis_neutral
  -> END
 
=== quiet ===
...
If it keeps going like this, we have to start thinking about the possible situations.#speaker:Lily #portrait:lily_neutral
I hate to say it, but we have to think about what might happen to George if he gets even worse. #speaker:Lily #portrait:lily_neutral
+ How can you say that? #speaker:Mr. Davis #portrait:davis_neutral
 He's my son. #speaker:Mr. Davis #portrait:davis_neutral
 I'm not going to let him go just like that. #speaker:Mr. Davis #portrait:davis_neutral
 -> possibility
 
+ That's not going to be a possibility. #speaker:Mr. Davis #portrait:davis_neutral
He's my son. #speaker:Mr. Davis #portrait:davis_neutral
I can't let anything happen to him. #speaker:Mr. Davis #portrait:davis_neutral
 -> possibility