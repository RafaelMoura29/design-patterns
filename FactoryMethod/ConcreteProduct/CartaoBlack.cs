using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoBlack(int LimiteCredito, int CobrancaoAnual)
        {
            this._tipoCartao = "Black";
            this._limiteCredito = LimiteCredito;
            this._cobrancaAnual = CobrancaoAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }
        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }

        public override int CobrancaoAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}