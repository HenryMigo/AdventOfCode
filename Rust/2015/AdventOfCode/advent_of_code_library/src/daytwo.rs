use std::fs::File;
use std::io::{BufRead, BufReader};

pub struct DayTwo;

impl DayTwo {
    pub fn part_one() -> i32 {
        let file = BufReader::new(File::open("daytwo.txt").expect("open failed"));
        -1
    }

    pub fn part_two() -> i32 {
        let file = BufReader::new(File::open("daytwo.txt").expect("open failed"));
        -1
    }
}
