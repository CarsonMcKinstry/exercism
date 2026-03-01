#[derive(Eq, PartialEq, Debug)]
pub struct Clock {
    hours: i32,
    minutes: i32,
}

impl Clock {
    pub fn new(hours: i32, minutes: i32) -> Self {
        let mut temp_hours = hours;
        let mut temp_minutes = minutes;

        while temp_minutes < 0 {
            temp_minutes += 60;
            temp_hours -= 1;
        }

        let num_additional_hours = temp_minutes / 60;
        let leftover_minutes = temp_minutes % 60;

        temp_hours += num_additional_hours;

        if temp_hours < 0 {
            while temp_hours < 0 {
                temp_hours += 24;
            }
        } else {
            while temp_hours > 23 {
                temp_hours -= 24;
            }
        }

        Self {
            hours: temp_hours,
            minutes: leftover_minutes
        }
    }

    pub fn add_minutes(&self, minutes: i32) -> Self {
        Self::new(
            self.hours,
            self.minutes + minutes
        )
    }

    pub fn to_string(&self) -> String {
        format!("{:0>2}:{:0>2}", self.hours, self.minutes)
    }
}