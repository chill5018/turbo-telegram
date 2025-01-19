'use server'

export async function calculateScore(
  prevState: {
    message?: string,
    payload?: FormData,
    score?: number,
  },
  formData: FormData) {
  const HR = formData.get("HR");
  const RR = formData.get("RR");
  const TEMP = formData.get("TEMP");

  const API_URL = process.env.API_V1_URL;
  const ENDPOINT = `${API_URL}/NEWS/calculate`

  if (!HR) {
    return { message: "Heart Rate is not filled", payload: formData }
  }

  if (!RR) {
    return { message: "Respiratory is not filled", payload: formData }
  }

  if (!TEMP) {
    return { message: "Body temperature is not filled", payload: formData }
  }

  const body = {
    measurements: [
      { "type": "HR", "value": Number(HR) },
      { "type": "RR", "value": Number(RR) },
      { "type": "TEMP", "value": Number(TEMP) },
    ]
  }

  const response = await fetch(ENDPOINT, {
    method: "POST",
    body: JSON.stringify(body),
    headers: {
      "Content-Type": "application/json"
    }
  });

  const result = await response.json();

  if (result.error) {
    return {
      message: result.error,
      payload: formData
    }
  }

  return {
    payload: formData,
    score: result.score,
  }
}
