use std::collections::HashSet;
use std::fs::File;
use std::io::{BufRead, BufReader};

pub struct DayThree;

struct DayThreeModel {
    houses: HashSet<(i32, i32), ()>,
}

impl DayThree {
    pub fn part_one() -> i32 {
        // NOTE: Starts at 1 as the first house always gets one present.
        let mut count = 1;

        let file = BufReader::new(File::open("files/daythree.txt").expect("open failed"));

        let mut instructions: Vec<char> = Vec::new();

        // Need to convert them into a list of chars for instructions
        for line in file.lines() {
            instructions = line.unwrap().chars().collect();
        }

        // TODO: Now the real fun begins

        return count;
    }

    pub fn part_two() -> i32 {
        -1
    }
}
