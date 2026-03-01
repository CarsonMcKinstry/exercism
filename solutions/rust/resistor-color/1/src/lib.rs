use enum_iterator::{all, Sequence};
use int_enum::IntEnum;

#[repr(u32)]
#[derive(Debug, Clone, Copy, PartialEq, Eq, Sequence, IntEnum)]
pub enum ResistorColor {
    Black = 0,
    Brown = 1,
    Red = 2,
    Orange = 3,
    Yellow = 4,
    Green = 5,
    Blue = 6,
    Violet = 7,
    Grey = 8,
    White = 9,
}

impl ResistorColor {
    pub fn to_string(&self) -> String {
        match self {
            ResistorColor::Black => "Black".to_string(),
            ResistorColor::Brown => "Brown".to_string(),
            ResistorColor::Red => "Red".to_string(),
            ResistorColor::Orange => "Orange".to_string(),
            ResistorColor::Yellow => "Yellow".to_string(),
            ResistorColor::Green => "Green".to_string(),
            ResistorColor::Blue => "Blue".to_string(),
            ResistorColor::Violet => "Violet".to_string(),
            ResistorColor::Grey => "Grey".to_string(),
            ResistorColor::White => "White".to_string(),
        }
    }
}

pub fn color_to_value(color: ResistorColor) -> u32 {
    color.int_value() as u32
}

pub fn value_to_color_string(value: u32) -> String {
   match ResistorColor::from_int(value) {
       Ok(v) => v.to_string(),
       _ => format!("value out of range")
   }
}

pub fn colors() -> Vec<ResistorColor> {
    all::<ResistorColor>().collect::<Vec<_>>()
}
