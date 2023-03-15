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
* I can tell you're hiding something.
    ...
    I'm just worried about George.
    -> worried
    
=== worried ===
* What are you worried about?
    Money.
    We don't have enough of it.
    How can we take care of our son?
    What's going to happen if we can't keep him in the hospital?
    -> happenToGeorge
* What about George?
    There's not enough money to keep him at the hospital.
    What's going to happen to him?
    -> happenToGeorge
*...
    We have to make sure he can stay at the hospital.
    We need more money.
    What'll happen to him if we can't pay?
    -> happenToGeorge
    
=== dropit ===
Just drop it. #speaker:Lily #portrait: lily_neutral
* I will. After you tell me what's wrong.
    ...you're so irritating.
    ..sigh...
    I'm just worried about George.
    -> worried
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSomeMore
* Fine. #speaker:Mr. Davis #portrait: davis_neutral
...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore

=== wrong ===
Nothing's wrong. #speaker:Lily #portrait: lily_neutral
* There's gotta be something wrong.
    Would you just drop it?
    Tell me and I will!
    ..sigh...
    I'm just worried about George.
    -> worried
* Are you sure?
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
* You gotta tell me.
    GOD! You're so irritating!
    Just tell me and I'll stop asking.
    ...
    I- I'm just worried about George.
    -> worried
* Okay. #speaker:Mr. Davis #portrait: davis_neutral
    Thank you. #speaker:Lily #portrait: lily_neutral
    ...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore
* ...alright. #speaker:Mr. Davis #portrait: davis_neutral
    ...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSomeMore
    
=== happenToGeorge ===
Nothing's going to happen to him.
Stop worrying.
My work'll take care of the bills.
What if they stop?
Things can change.
I heard on the news that there's going to be a new Secretary of Health.
What if that changes everything?
Also, you're not exactly like you were when you were twenty, you know.
Fall over and you're in the hospital.
God help me if my son AND my husband are in the hospital.
* If you're that worried then do something about it.
    Nothing's going to happen.
    Nothing's going to happen?
    You're kidding.
    Did you forget that we live in America??
    There is nothing calm about this country.
    There is always something about to happen.
    I can't do anything about it!
    I don't even have a job!
    And I've got George AND Alex to take care of.
    -> getAJob
    
* You worry too much.
    Nothing's going to happen.
    Nothing's going to happen?
    You're kidding.
    Did you forget that we live in America??
    There is nothing calm about this country.
    There is always something about to happen.
    We can't afford to not worry.
    We've got George AND Alex to take care of.
    And I can't even earn my own money to provide for them.
    ->getAJob
* ...
    Don't think I've forgotten about Alex.
    I don't have a job.
    What can I do if you get injured?
    Alex and I...
    Well, there's not much I can do.
    This is America.
    Nobody's going to give a shit about us.
    Nobody's going to care that we have two sons to worry about.
    They're all worrying about their kids!
    -> getAJob

=== getAJob ===
* Then get a job.
    Umm.. taking care of our two sons is a job.
    That's not a very helpful thing to say, dear husband.
    ...
    Look, I don't want to talk anymore.
    I have to go to the hospital to see George.
    You have to go to work.
    ...
    -> END
    
* I'll help you find a job.
    Well, that's nice and all, but taking care of our two sons is enough work.
    One's in the hospital and neither of them can take care of themselves.
    I can't leave them alone.
    ...
    I'm going to the hospital soon to see George and you've gotta go to work.
     
    We'll talk later.
    Okay..
    -> END
    
=== silence1 ===
Good morning. #speaker:Lily #portrait: lily_neutral
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
*Morning. #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
    
=== haveSome ===
Have some breakfast.
*Smells good.
...thanks.
-> thanks

*Thanks.
..mhm..
-> thanks

*...
You're welcome.
...
-> thanks

=== thanks ===
*Are you okay?
-> notOkay

*Is something wrong?
-> notOkay

=== notOkay ===
...
I'm just worried about George.
-> worried

=== haveSomeMore ===
But I feel like there's something that needs to be resolved here.
I can tell you're dying to talk about it.
GOD you're so annoying!
*Look, just tell me and I'll get outta your hair.
I'm worried about George!
Are you happy now?
Very.
-> worried

*Tell me? Please?
Oh. My. God.
Sigh...
I'm worried about George.
-> worried

*Someone woke up on the wrong side of the bed...
Can you shut the hell up?
Lily.
We're husband and wife.
Aren't we supposed to be telling each other things??
Okay, but I don't want to talk about it right now.
If you're going to go off about being a good couple then why don't you shove off and give me some space?
Just tell me and I'll shut up.
...
Fine!
I'm worried about George.
-> worried





