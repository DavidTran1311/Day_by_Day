Dad! You came! #speaker:George #portrait:george_neutral
Hey, buddy. #speaker:Mr. Davis #portrait:davis_neutral
... #speaker:Lily #portrait:lily_neutral
Mom was just reading me a story. #speaker:George #portrait:george_neutral
Yeah? You really love books, don't you? #speaker:Mr. Davis #portrait:davis_neutral
Mhm! They're nice to listen to, but mom's not a very good storyteller :P #speaker:George #portrait:george_neutral
Hey! Next time I won't read to you then.
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
Hey, George, I have to talk to your dad for a second.
...oh. #speaker:George #portrait:george_neutral
...okay mom. #speaker:George #portrait:george_neutral

...
You came.
+ Yeah. #speaker:Mr. Davis #portrait:davis_neutral
 -> listen
+ Why wouldn't I? #speaker:Mr. Davis #portrait:davis_neutral
 -> listen
 
 === listen ===
 I don't know, I just thought you wouldn't listen to me.
 Wouldn't be the first time.
 + Did you bring me here just to get angry at me? #speaker:Mr. Davis #portrait:davis_neutral
  -> angry
 + Don't be so surprised. #speaker:Mr. Davis #portrait:davis_neutral
  -> surprised
 + ...
 -> unspoken  

=== unspoken ===
...sigh...
I get that you have a job and it's the only thing keeping George here.
...
Look, I don't want to get into this right now.
+ ...okay. What did you need to tell me?
 -> condition
+ ...sooo, how's George?
 -> condition

=== angry ===
...no.
But, how can I not?
This is the first time you come here in weeks.
I get that you have a job and it's the only thing keeping George here.
...sigh...
I don't want to get into this right now.
+ Okay, fine. But I'm here now. 
What did you need to tell me?
 -> condition
+ Good. 
So, what's going on? Is George okay?
 -> condition

=== surprised ===
How can I not?
This is the first time you've been here in weeks.
I get that you have job and it's the only thing keeping George here.
...sigh...
I don't want to get into this right now.
I'm too tired for this.
We're here for George anyway.
+ Right, so what did you need to tell me?
 -> condition
+ How is he?
 -> condition

=== condition ===
The doctor says his condition is worsening.
I- I don't know how long he has.
Didn't the doctor say that he was looking better?
I know, I know. 
She said something about the leukemia and how the treatment isn't going well.
I don't know how long I can go like this.
+ What is that supposed to mean?
 -> supposedToMean
+ ...
 -> quiet


=== supposedToMean ===
I'm just saying, we have to think about the situation if something, y'know, bad happens.
+ I'm not thinking about that.
 He's my son.
 I don't want to think that anything will happen to my son.
 He still has time.
 -> possibility

+ How can you think that?
He's my son.
I can't believe you'd think something like that.
We're far from that. He still has time.
 -> possibility

=== possibility ===
 Oh, so now you're going to act like a father?
 He's my son too.
 We have to consider it as a possibility.
 I'm just preparing us for what might happen.
 I'm not going to let it go like that without even seeing what can be done.
 I won't.
 He's too young.
 There's so much for him to see.
 ...
 I want to talk to the doctor.
 There must be something more that can be done.
  -> END
 
=== quiet ===
...
If it keeps going like this, we have to start thinking about the possible situations.
I hate to say it, but we have to think about what might happen to George if he gets even worse.
+ How can you say that?
 He's my son.
 I'm not going to let him go just like that.
 -> possibility
 
+ That's not going to be a possibility.
He's my son.
I can't let anything happen to him.
 -> possibility