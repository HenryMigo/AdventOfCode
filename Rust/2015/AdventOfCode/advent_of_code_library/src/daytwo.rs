use std::fs::File;
use std::io::{BufRead, BufReader};

pub struct DayTwo;

impl DayTwo {
    pub fn part_one() -> i32 {
        let file = BufReader::new(File::open("daytwo.txt").expect("open failed"));

        let mut areas: Vec<i32> = Vec::new();

        for line in file.lines() {
            let line_clone = line.expect("line failed").clone();
            let mut measurements = line_clone.split("x");

            let length = DayTwo::convert_string_to_int(measurements.next().expect("Length failed"));
            let width = DayTwo::convert_string_to_int(measurements.next().expect("Width failed"));
            let height = DayTwo::convert_string_to_int(measurements.next().expect("Height failed"));

            let mut smallest = length;

            if smallest > width {
                smallest = width;
            }

            if smallest > height {
                smallest = height;
            }

            let result = (2 * (length * width))
                + (2 * (width * height))
                + (2 * (height * length))
                + smallest;

            areas.push(result);
        }

        let mut result = 0;

        for area in areas {
            result = result + area;
        }

        return result;
    }

    pub fn part_two() -> i32 {
        _ = BufReader::new(File::open("daytwo.txt").expect("open failed"));
        -1
    }

    fn convert_string_to_int(input: &str) -> i32 {
        input.parse::<i32>().unwrap()
    }
}
