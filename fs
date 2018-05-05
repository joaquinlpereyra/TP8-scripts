#!/bin/bash
path="/home/$1"
df $path | awk '{print $1}' | tail -n 1
