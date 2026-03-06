#!/bin/bash

PR_IDS=$(gh pr list --json number)

for NUMBER in $(jq '.[].number' <<< $PR_IDS)
do 
    gh pr merge "$NUMBER" --merge
done
