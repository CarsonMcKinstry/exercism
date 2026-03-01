defmodule Bob do
  def hey(input) do
    cond do
      is_silence?(input) ->
        "Fine. Be that way!"
      is_shouted_question?(input) -> 
        "Calm down, I know what I'm doing!"
      is_shouting?(input) -> 
        "Whoa, chill out!"
      is_question?(input) -> 
        "Sure."
      true -> 
        "Whatever."
    end
  end

  def is_silence?(input), do: String.match?(input, ~r/^\s{0,}$/)

  def is_shouting?(input) do
    chars = String.replace(input, ~r/[\W\d]/, "")
      |> String.split("", trim: true)
    cond do
      length(chars) > 0 ->
        Enum.all?(chars, &is_uppercase?/1)
      true -> false
    end
  end

  def is_question?(input) do
    String.ends_with?(input, "?")
  end

  def is_uppercase?(char) do
    String.match?(char, ~r/^\p{Lu}$/u)
  end
  
  def is_shouted_question?(input) do
    is_question?(input) and is_shouting?(input)
  end
end