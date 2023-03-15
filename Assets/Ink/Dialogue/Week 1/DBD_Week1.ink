-> main

=== main ===
... #speaker:Lily #portrait: lily_neutral
* ... #speaker:Mr. Davis #portrais: davis_neutral
    -> silence1
* Morning. #speaker:Mr. Davis #portrait: davis_neutral
    -> morning
    
=== morning ===
Mhm...sure. #speaker:Lily #portrait: lily_neutral
* Is there something bothering you? #speaker:Mr. Davis #portrait: davis_neutral
    -> bothering
*What's wrong? #speaker:Mr. Davis #portrait: davis_neutral
    ->  wrong
* ... #speaker:Mr. Davis #portrait: davis_neutral
    ->haveSome
    
=== bothering ===
Not at all. #speaker:Lily #portrait: lily_neutral
* There's obviously something bothering you. #speaker:Mr. Davis #portrait: davis_neutral
    Nothing's bothering me! #speaker:Lily #portrait: lily_neutral
    sigh... #speaker:Lily #portrait: lily_neutral
    Look, I don't want to talk about it. #speaker:Lily #portrait: lily_neutral
    -> dropit
* I can tell you're hiding something. #speaker:Mr. Davis #portrait: davis_neutral
    ... #speaker:Lily #portrait: lily_neutral
    I'm just worried about George. #speaker:Lily #portrait: lily_neutral
    -> worried
    
=== worried ===
* What are you worried about? #speaker:Mr. Davis #portrait: davis_neutral
    Money. #speaker:Lily #portrait: lily_neutral
    We don't have enough of it. #speaker:Lily #portrait: lily_neutral
    How can we take care of our son? #speaker:Lily #portrait: lily_neutral
    What's going to happen if we can't keep him in the hospital? #speaker:Lily #portrait: lily_neutral
    -> happenToGeorge
* What about George? #speaker:Mr. Davis #portrait: davis_neutral
    There's not enough money to keep him at the hospital. #speaker:Lily #portrait: lily_neutral
    What's going to happen to him? #speaker:Lily #portrait: lily_neutral
    -> happenToGeorge
*... #speaker:Mr. Davis #portrait: davis_neutral
    We have to make sure he can stay at the hospital. #speaker:Lily #portrait: lily_neutral
    We need more money. #speaker:Lily #portrait: lily_neutral
    What'll happen to him if we can't pay? #speaker:Lily #portrait: lily_neutral
    -> happenToGeorge
    
=== dropit ===
Just drop it. #speaker:Lily #portrait: lily_neutral
* I will. After you tell me what's wrong. #speaker:Mr. Davis #portrait: davis_neutral
    ...you're so irritating. #speaker:Lily #portrait: lily_neutral
    ..sigh... #speaker:Lily #portrait: lily_neutral
    I'm just worried about George. #speaker:Lily #portrait: lily_neutral
    -> worried
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSomeMore
* Fine. #speaker:Mr. Davis #portrait: davis_neutral
...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore

=== wrong ===
Nothing's wrong. #speaker:Lily #portrait: lily_neutral
* There's gotta be something wrong. #speaker:Mr. Davis #portrait: davis_neutral
    Would you just drop it? #speaker:Lily #portrait: lily_neutral
    Tell me and I will! #speaker:Mr. Davis #portrait: davis_neutral
    ..sigh... #speaker:Lily #portrait: lily_neutral
    I'm just worried about George. #speaker:Lily #portrait: lily_neutral
    -> worried
* Are you sure? #speaker:Mr. Davis #portrait: davis_neutral
    Yes! #speaker:Lily #portrait: lily_neutral
    -> stopAsking
* Alright... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSomeMore
    
=== stopAsking ===
Can you please stop asking? #speaker:Lily #portrait: lily_neutral
* I can't ask how you're feeling? #speaker:Mr. Davis #portrait: davis_neutral
    -> feeling
* ...Fine. #speaker:Mr. Davis #portrait: davis_neutral
    Okay... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore
    
=== feeling ===
I just don't want to talk about it right now! Okay? #speaker:Lily #portrait: lily_neutral
* You gotta tell me. #speaker:Mr. Davis #portrait: davis_neutral
    GOD! You're so irritating!
    Just tell me and I'll stop asking. #speaker:Mr. Davis #portrait: davis_neutral
    ... #speaker:Lily #portrait: lily_neutral
    I- I'm just worried about George. #speaker:Lily #portrait: lily_neutral
    -> worried
* Okay. #speaker:Mr. Davis #portrait: davis_neutral
    Thank you. #speaker:Lily #portrait: lily_neutral
    ...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore
* ...alright. #speaker:Mr. Davis #portrait: davis_neutral
    ...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore
    
=== happenToGeorge ===
Nothing's going to happen to him. #speaker:Mr. Davis #portrait: davis_neutral
Stop worrying. #speaker:Mr. Davis #portrait: davis_neutral
My work'll take care of the bills. #speaker:Mr. Davis #portrait: davis_neutral
What if they stop? #speaker:Lily #portrait: lily_neutral
Things can change. #speaker:Lily #portrait: lily_neutral
I heard on the news that there's going to be a new Secretary of Health. #speaker:Lily #portrait: lily_neutral
What if that changes everything? #speaker:Lily #portrait: lily_neutral
Also, you're not exactly like you were when you were twenty, you know. #speaker:Lily #portrait: lily_neutral
Fall over and you're in the hospital. #speaker:Lily #portrait: lily_neutral
God help me if my son AND my husband are in the hospital. #speaker:Lily #portrait: lily_neutral
* If you're that worried then do something about it. #speaker:Mr. Davis #portrait: davis_neutral
    Nothing's going to happen. #speaker:Mr. Davis #portrait: davis_neutral
    Nothing's going to happen? #speaker:Lily #portrait: lily_neutral
    You're kidding. #speaker:Lily #portrait: lily_neutral
    Did you forget that we live in America?? #speaker:Lily #portrait: lily_neutral
    There is nothing calm about this country. #speaker:Lily #portrait: lily_neutral
    There is always something about to happen. #speaker:Lily #portrait: lily_neutral
    I can't do anything about it! #speaker:Lily #portrait: lily_neutral
    I don't even have a job! #speaker:Lily #portrait: lily_neutral
    And I've got George AND Alex to take care of. #speaker:Lily #portrait: lily_neutral
    -> getAJob
    
* You worry too much. #speaker:Mr. Davis #portrait: davis_neutral
    Nothing's going to happen. #speaker:Mr. Davis #portrait: davis_neutral
    Nothing's going to happen? #speaker:Lily #portrait: lily_neutral
    You're kidding. #speaker:Lily #portrait: lily_neutral
    Did you forget that we live in America?? #speaker:Lily #portrait: lily_neutral
    There is nothing calm about this country. #speaker:Lily #portrait: lily_neutral
    There is always something about to happen. #speaker:Lily #portrait: lily_neutral
    We can't afford to not worry. #speaker:Lily #portrait: lily_neutral
    We've got George AND Alex to take care of. #speaker:Lily #portrait: lily_neutral
    And I can't even earn my own money to provide for them. #speaker:Lily #portrait: lily_neutral
    ->getAJob
* ... #speaker:Mr. Davis #portrait: davis_neutral
    Don't think I've forgotten about Alex. #speaker:Lily #portrait: lily_neutral
    I don't have a job. #speaker:Lily #portrait: lily_neutral
    What can I do if you get injured? #speaker:Lily #portrait: lily_neutral
    Alex and I... #speaker:Lily #portrait: lily_neutral
    Well, there's not much I can do. #speaker:Lily #portrait: lily_neutral
    This is America. #speaker:Lily #portrait: lily_neutral
    Nobody's going to give a shit about us. #speaker:Lily #portrait: lily_neutral
    Nobody's going to care that we have two sons to worry about. #speaker:Lily #portrait: lily_neutral
    They're all worrying about their kids! #speaker:Lily #portrait: lily_neutral
    -> getAJob

=== getAJob ===
* Then get a job. #speaker:Mr. Davis #portrait: davis_neutral
    Umm.. taking care of our two sons is a job. #speaker:Lily #portrait: lily_neutral
    That's not a very helpful thing to say, dear husband. #speaker:Lily #portrait: lily_neutral
    ... #speaker:Mr. Davis #portrait: davis_neutral
    Look, I don't want to talk anymore. #speaker:Lily #portrait: lily_neutral
    I have to go to the hospital to see George. #speaker:Lily #portrait: lily_neutral
    You have to go to work. #speaker:Lily #portrait: lily_neutral
    ... #speaker:Mr. Davis #portrait: davis_neutral
    -> END
    
* I'll help you find a job. #speaker:Mr. Davis #portrait: davis_neutral
    Well, that's nice and all, but taking care of our two sons is enough work. #speaker:Lily #portrait: lily_neutral
    One's in the hospital and neither of them can take care of themselves. #speaker:Lily #portrait: lily_neutral
    I can't leave them alone. #speaker:Lily #portrait: lily_neutral
    ... #speaker:Mr. Davis #portrait: davis_neutral
    I'm going to the hospital soon to see George and you've gotta go to work. #speaker:Lily #portrait: lily_neutral
     
    We'll talk later. #speaker:Lily #portrait: lily_neutral
    Okay.. #speaker:Mr. Davis #portrait: davis_neutral
    -> END
    
=== silence1 ===
Good morning. #speaker:Lily #portrait: lily_neutral
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
*Morning. #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
    
=== haveSome ===
Have some breakfast. #speaker:Lily #portrait: lily_neutral
*Smells good. #speaker:Mr. Davis #portrait: davis_neutral
...thanks. #speaker:Lily #portrait: lily_neutral
-> thanks

*Thanks. #speaker:Mr. Davis #portrait: davis_neutral
..mhm.. #speaker:Lily #portrait: lily_neutral
-> thanks

*... #speaker:Mr. Davis #portrait: davis_neutral
You're welcome. #speaker:Lily #portrait: lily_neutral
... #speaker:Mr. Davis #portrait: davis_neutral
-> thanks

=== thanks ===
*Are you okay? #speaker:Mr. Davis #portrait: davis_neutral
-> notOkay

*Is something wrong? #speaker:Mr. Davis #portrait: davis_neutral
-> notOkay

=== notOkay ===
...
I'm just worried about George. #speaker:Lily #portrait: lily_neutral
-> worried

=== haveSomeMore ===
But I feel like there's something that needs to be resolved here. #speaker:Mr. Davis #portrait: davis_neutral
I can tell you're dying to talk about it. #speaker:Mr. Davis #portrait: davis_neutral
GOD you're so annoying! #speaker:Lily #portrait: lily_neutral
*Look, just tell me and I'll get outta your hair. #speaker:Mr. Davis #portrait: davis_neutral
I'm worried about George! #speaker:Lily #portrait: lily_neutral
Are you happy now? #speaker:Lily #portrait: lily_neutral
Very. #speaker:Mr. Davis #portrait: davis_neutral
-> worried

*Tell me? Please? #speaker:Mr. Davis #portrait: davis_neutral
Oh. My. God. #speaker:Lily #portrait: lily_neutral
Sigh... #speaker:Lily #portrait: lily_neutral
I'm worried about George. #speaker:Lily #portrait: lily_neutral
-> worried

*Someone woke up on the wrong side of the bed... #speaker:Mr. Davis #portrait: davis_neutral
Can you shut the hell up? #speaker:Lily #portrait: lily_neutral
Lily. #speaker:Mr. Davis #portrait: davis_neutral
We're husband and wife. #speaker:Mr. Davis #portrait: davis_neutral
Aren't we supposed to be telling each other things?? #speaker:Mr. Davis #portrait: davis_neutral
Okay, but I don't want to talk about it right now. #speaker:Lily #portrait: lily_neutral
If you're going to go off about being a good couple then why don't you shove off and give me some space? #speaker:Lily #portrait: lily_neutral
Just tell me and I'll shut up. #speaker:Mr. Davis #portrait: davis_neutral
... #speaker:Lily #portrait: lily_neutral
Fine! #speaker:Lily #portrait: lily_neutral
I'm worried about George. #speaker:Lily #portrait: lily_neutral
-> worried





