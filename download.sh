#!/bin/bash

# Directory where you want to save the Gist content
destination_directory="/path/to/destination_directory"

# Loop through Gists
for i in {1..28}; do
    # Checkout Gist branch
    git checkout g$i/master
    
    # Copy all files to destination directory
    cp -r ./* "../gists"
    
    # Move back to the main branch
    git checkout main
done

