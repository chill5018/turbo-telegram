import { NewsForm } from "@aidn/components/NewsForm";
import { Typography } from "@aidn/components/Typography";
import { TextVariants } from "@aidn/components/Typography/types";


export default function Home() {

  return (
    <div className="flex justify-center mt-24">
      <div className="flex flex-col gap-10">
        <Typography variant={TextVariants.header2}>NEWS score calculator</Typography>
        <NewsForm />
      </div>
    </div>
  );
}
