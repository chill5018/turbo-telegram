import { Typography } from "../Typography"
import { TextVariants } from "../Typography/types"
import styles from './styles.module.css';

type ScoreCardProps = {
  score?: number
}
export const ScoreCard = ({ score }: ScoreCardProps) => {
  if (score === undefined) {
    return null;
  }



  return (
    <div className={styles.scoreCard}>
      <Typography variant={TextVariants.standard20}>News score:</Typography>
      <Typography variant={TextVariants.header2}>{score}</Typography>
    </div>
  )
}
