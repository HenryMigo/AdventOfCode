use std::fs::File;
use std::io::BufReader;

pub struct DayTwo;

impl DayTwo {
    pub fn part_one() -> i32 {
        _ = BufReader::new(File::open("daytwo.txt").expect("open failed"));
        -1
    }

    pub fn part_two() -> i32 {
        _ = BufReader::new(File::open("daytwo.txt").expect("open failed"));
        -1
    }
}
