# IOBTag
Author: Nestor Prieto Chavana

This repo contains code for an application used for hand labelling text data as part of my MSc research project:
> Extraction of Adverse Drug Reaction Reports from Social Media: A Deep Learning Approach

It was developed to help label text sequences in the IOB scheme. 6 classes are used:

Concept | Definition | Label 
--- | --- | ---
ADR | A negative reaction to a drug | B-ADR, I-ADR
IND | A positive reaction or an effect not caused by the drug | B-IND, I-IND
Drug | Mention of a drug | M
Outside | Word not in interest classes | O

However the code could be easily adapted to use any other set of labels. 

The application expects the files to be pipe separated, and include at least the following columns:

Column Name | Description
--- | ---
Body | Full sentence text
Words | Tokens in sentence, separated by a ~
Wordlen | Number of tokens in sentence, used for validation only
