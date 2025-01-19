'use client'
import { calculateScore } from "@aidn/actions/calculateScore";
import { useActionState, useEffect, useRef, useState } from "react";
import { Button } from "../Button";
import { InputField } from "../InputField";
import { Typography } from "../Typography";
import { TextVariants } from "../Typography/types";
import { ScoreCard } from "../ScoreCard";

const initialState = {
  message: "",
  payload: new FormData(),
  score: undefined,
}

export const NewsForm = () => {
  const formRef = useRef<HTMLFormElement>(null);
  const [state, formAction] = useActionState(calculateScore, initialState);

  const [formState, setFormState] = useState(state);

  useEffect(() => {
    setFormState(state)
  }, [state])

  const handleReset = (event: React.SyntheticEvent) => {
    event.preventDefault();
    setFormState(initialState);
  }

  /**
   * NOTE: Comment out min max for server errors
   *
   *  */

  return (
    <>
      <form ref={formRef} action={formAction}>
        <div className="flex flex-col gap-10 min-w-80">
          <InputField
            name="TEMP"
            title="Body temperature"
            description="Degrees celcius"
            type="decimal"
            min={32}
            max={42}
            defaultValue={Number(formState.payload?.get("TEMP")) || ""} />
          <InputField
            name="HR"
            title="Heartrate"
            description="Beats per minute"
            type="number"
            min={26}
            max={220}
            defaultValue={Number(formState.payload?.get("HR")) || ""} />
          <InputField
            name="RR"
            title="Respiratory rate"
            description="Breaths per minute"
            type="number"
            // min={4}
            // max={60}
            defaultValue={Number(formState.payload?.get("RR")) || ""} />

          <div className="flex gap-3">
            <Button variant="primary" type="submit">
              Calculate NEWS score
            </Button>
            <Button variant="secondary" type="button" onClick={handleReset}>
              Reset form
            </Button>
          </div>
        </div>
      </form>
      <ScoreCard score={formState.score} />
      <div className="w-full max-w-80">
        {formState?.message || ""}
      </div>
    </>
  )
}
